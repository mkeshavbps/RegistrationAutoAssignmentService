using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RegistrationAutoAssignment.Repositories.Utilities
{
    /// <summary>
    /// Utility class for serialize/de-serialize the objects
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Gets the XML string for an object 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToXml<T>(T obj)
        {
            using (var stringWriter = new StringWriter(new StringBuilder()))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(stringWriter, obj);
                return stringWriter.ToString();
            }
        }

        /// <summary>
        /// Converts the string to dataset
        /// </summary>
        /// <param name="xmlData"></param>
        /// <returns></returns>
        public static DataSet ConvertXmlToDataSet(string xmlData)
        {
            using (var reader = new XmlTextReader(new StringReader(xmlData)))
                try
                {
                    var xmlDs = new DataSet();
                    xmlDs.ReadXml(reader);

                    return xmlDs;
                }
                finally
                {
                    reader.Close();
                }
        }


        /// <summary>
        /// Convert the list to the data table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (var item in items)
            {
                var values = new object[Props.Length];
                for (var i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }


        /// <summary>
        /// Convert the List to a DataSet
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>DataSet</returns>
        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            var elementType = typeof(T);
            using (var dataSet = new DataSet())
            {
                using (var table = new DataTable())
                {
                    dataSet.Tables.Add(table);
                    //add a column to table for each public property on T
                    var props = elementType.GetProperties();
                    foreach (var propInfo in props)
                    {
                        var pi = propInfo.PropertyType;
                        var colType = Nullable.GetUnderlyingType(pi) ?? pi;
                        table.Columns.Add(propInfo.Name, colType);
                    }
                    //go through each property on T and add each value to the table
                    foreach (var item in list)
                    {
                        var row = table.NewRow();
                        foreach (var propInfo in props)
                        {
                            row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                        }
                        table.Rows.Add(row);
                    }
                }
                return dataSet;
            }
        }

        /// <summary>
        /// Check if the input XML is well-formed.
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static bool TryParseXml(string xml)
        {
            try
            {
                var document = XDocument.Load(xml);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }

        }
    }
}
