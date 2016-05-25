﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationAutoAssignment.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using System.Data.Common;

    public partial class ExtractAspenEntities : DbContext
    {
        private DbConnection _cntxDbConnect;

        public ExtractAspenEntities()
            : base("name=ExtractAspenEntities")
        {
        }

        public ExtractAspenEntities(DbConnection _cntxDbConnect)
        {
            this._cntxDbConnect = _cntxDbConnect;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACADEMIC_TRACK> ACADEMIC_TRACK { get; set; }
        public virtual DbSet<ACADEMIC_TRACK_COURSE> ACADEMIC_TRACK_COURSE { get; set; }
        public virtual DbSet<ACADEMIC_TRACK_GRADE> ACADEMIC_TRACK_GRADE { get; set; }
        public virtual DbSet<ACADEMIC_TRACK_SELECTION> ACADEMIC_TRACK_SELECTION { get; set; }
        public virtual DbSet<ACCESS_LOG> ACCESS_LOG { get; set; }
        public virtual DbSet<ADDRESS_GRID_CODE> ADDRESS_GRID_CODE { get; set; }
        public virtual DbSet<ANALYTIC_COLUMN_DEFINITION> ANALYTIC_COLUMN_DEFINITION { get; set; }
        public virtual DbSet<ANALYTIC_DEFINITION> ANALYTIC_DEFINITION { get; set; }
        public virtual DbSet<ANALYTIC_RESULT> ANALYTIC_RESULT { get; set; }
        public virtual DbSet<ASSESSMENT_COLUMN_DEFINITION> ASSESSMENT_COLUMN_DEFINITION { get; set; }
        public virtual DbSet<ASSESSMENT_DEFINITION> ASSESSMENT_DEFINITION { get; set; }
        public virtual DbSet<ASSESSMENT_RESPONSE_DEFINITION> ASSESSMENT_RESPONSE_DEFINITION { get; set; }
        public virtual DbSet<ASSIGNMENT_REPOSITORY_ITEM> ASSIGNMENT_REPOSITORY_ITEM { get; set; }
        public virtual DbSet<CALENDAR> CALENDARs { get; set; }
        public virtual DbSet<CALENDAR_SCHOOL> CALENDAR_SCHOOL { get; set; }
        public virtual DbSet<CALENDAR_SCHOOL_DATE> CALENDAR_SCHOOL_DATE { get; set; }
        public virtual DbSet<CALENDAR_STAFF> CALENDAR_STAFF { get; set; }
        public virtual DbSet<CALENDAR_STAFF_DATE> CALENDAR_STAFF_DATE { get; set; }
        public virtual DbSet<CLASS_SIZE_DEFINITION> CLASS_SIZE_DEFINITION { get; set; }
        public virtual DbSet<CLASS_SIZE_DEFINITION_GRADE> CLASS_SIZE_DEFINITION_GRADE { get; set; }
        public virtual DbSet<COMMENT_BANK_CODE> COMMENT_BANK_CODE { get; set; }
        public virtual DbSet<COMMENT_BANK_TABLE> COMMENT_BANK_TABLE { get; set; }
        public virtual DbSet<CONTACT> CONTACTs { get; set; }
        public virtual DbSet<CONTENT_FILE> CONTENT_FILE { get; set; }
        public virtual DbSet<CONTENT_FOLDER> CONTENT_FOLDER { get; set; }
        public virtual DbSet<CONTENT_GOOGLE_DOC> CONTENT_GOOGLE_DOC { get; set; }
        public virtual DbSet<CONTENT_ITEM> CONTENT_ITEM { get; set; }
        public virtual DbSet<CONTENT_MERCURY> CONTENT_MERCURY { get; set; }
        public virtual DbSet<CONTENT_NODE> CONTENT_NODE { get; set; }
        public virtual DbSet<CONTENT_NOTE> CONTENT_NOTE { get; set; }
        public virtual DbSet<CONTENT_PROPERTY> CONTENT_PROPERTY { get; set; }
        public virtual DbSet<CONTENT_PROPERTY_DESCRIPTOR> CONTENT_PROPERTY_DESCRIPTOR { get; set; }
        public virtual DbSet<CONTENT_STANDARDS> CONTENT_STANDARDS { get; set; }
        public virtual DbSet<CONTENT_WEB_LINK> CONTENT_WEB_LINK { get; set; }
        public virtual DbSet<COURSE> COURSEs { get; set; }
        public virtual DbSet<COURSE_CERTIFICATION> COURSE_CERTIFICATION { get; set; }
        public virtual DbSet<COURSE_REQUISITE> COURSE_REQUISITE { get; set; }
        public virtual DbSet<COURSE_SCHEDULE> COURSE_SCHEDULE { get; set; }
        public virtual DbSet<COURSE_SCHOOL> COURSE_SCHOOL { get; set; }
        public virtual DbSet<COURSE_VISIBILITY> COURSE_VISIBILITY { get; set; }
        public virtual DbSet<CURRICULUM_CONTENT> CURRICULUM_CONTENT { get; set; }
        public virtual DbSet<CURRICULUM_COURSE_LESSON> CURRICULUM_COURSE_LESSON { get; set; }
        public virtual DbSet<CURRICULUM_DOCUMENT_ELEMENT> CURRICULUM_DOCUMENT_ELEMENT { get; set; }
        public virtual DbSet<CURRICULUM_DOCUMENT_STRUCTURE> CURRICULUM_DOCUMENT_STRUCTURE { get; set; }
        public virtual DbSet<CURRICULUM_INSTANCE> CURRICULUM_INSTANCE { get; set; }
        public virtual DbSet<CURRICULUM_INSTANCE_DATE> CURRICULUM_INSTANCE_DATE { get; set; }
        public virtual DbSet<CURRICULUM_LESSON_PLAN> CURRICULUM_LESSON_PLAN { get; set; }
        public virtual DbSet<CURRICULUM_MAP> CURRICULUM_MAP { get; set; }
        public virtual DbSet<CURRICULUM_NARRATIVE> CURRICULUM_NARRATIVE { get; set; }
        public virtual DbSet<CURRICULUM_STANDARD> CURRICULUM_STANDARD { get; set; }
        public virtual DbSet<DATA_AUDIT> DATA_AUDIT { get; set; }
        public virtual DbSet<DATA_CALCULATE_FIELD> DATA_CALCULATE_FIELD { get; set; }
        public virtual DbSet<DATA_CALCULATE_FIELD_MEMBER> DATA_CALCULATE_FIELD_MEMBER { get; set; }
        public virtual DbSet<DATA_DICTIONARY_EXTENDED> DATA_DICTIONARY_EXTENDED { get; set; }
        public virtual DbSet<DATA_FIELD> DATA_FIELD { get; set; }
        public virtual DbSet<DATA_FIELD_CONFIG> DATA_FIELD_CONFIG { get; set; }
        public virtual DbSet<DATA_FIELD_EXTENDED> DATA_FIELD_EXTENDED { get; set; }
        public virtual DbSet<DATA_FIELD_MASK> DATA_FIELD_MASK { get; set; }
        public virtual DbSet<DATA_INDEX> DATA_INDEX { get; set; }
        public virtual DbSet<DATA_RELATION> DATA_RELATION { get; set; }
        public virtual DbSet<DATA_RELATION_DISTRICT> DATA_RELATION_DISTRICT { get; set; }
        public virtual DbSet<DATA_RELATION_PATH> DATA_RELATION_PATH { get; set; }
        public virtual DbSet<DATA_RELATION_PATH_FIELD> DATA_RELATION_PATH_FIELD { get; set; }
        public virtual DbSet<DATA_REQUEST> DATA_REQUEST { get; set; }
        public virtual DbSet<DATA_TABLE> DATA_TABLE { get; set; }
        public virtual DbSet<DATA_TABLE_CONFIG> DATA_TABLE_CONFIG { get; set; }
        public virtual DbSet<DATA_TABLE_EXTENDED> DATA_TABLE_EXTENDED { get; set; }
        public virtual DbSet<DATA_TRANSACTION> DATA_TRANSACTION { get; set; }
        public virtual DbSet<DATA_VALIDATE_FIELD> DATA_VALIDATE_FIELD { get; set; }
        public virtual DbSet<DATA_VALIDATION_RULE> DATA_VALIDATION_RULE { get; set; }
        public virtual DbSet<DISTRICT_SCHOOL_YEAR_CONTEXT> DISTRICT_SCHOOL_YEAR_CONTEXT { get; set; }
        public virtual DbSet<EVENT> EVENTs { get; set; }
        public virtual DbSet<EXAM_COMPONENT> EXAM_COMPONENT { get; set; }
        public virtual DbSet<EXAM_ENTRY> EXAM_ENTRY { get; set; }
        public virtual DbSet<EXAM_ENTRY_CONTROL> EXAM_ENTRY_CONTROL { get; set; }
        public virtual DbSet<EXAM_ENTRY_EXPORT> EXAM_ENTRY_EXPORT { get; set; }
        public virtual DbSet<EXAM_OPTION> EXAM_OPTION { get; set; }
        public virtual DbSet<EXAM_OPTION_COMPONENT> EXAM_OPTION_COMPONENT { get; set; }
        public virtual DbSet<EXAM_RESULT> EXAM_RESULT { get; set; }
        public virtual DbSet<EXAM_ROOM> EXAM_ROOM { get; set; }
        public virtual DbSet<EXAM_SEASON> EXAM_SEASON { get; set; }
        public virtual DbSet<EXAM_SECTION_OPTION> EXAM_SECTION_OPTION { get; set; }
        public virtual DbSet<EXAM_SERIES> EXAM_SERIES { get; set; }
        public virtual DbSet<EXAM_SYLLABUS> EXAM_SYLLABUS { get; set; }
        public virtual DbSet<EXAM_TIMETABLE> EXAM_TIMETABLE { get; set; }
        public virtual DbSet<EXAM_TIMETABLE_ROOM> EXAM_TIMETABLE_ROOM { get; set; }
        public virtual DbSet<EXAM_TRANSFER_FILE> EXAM_TRANSFER_FILE { get; set; }
        public virtual DbSet<EXPORT_FORMAT_DEFINITION> EXPORT_FORMAT_DEFINITION { get; set; }
        public virtual DbSet<EXPORT_FORMAT_FIELD> EXPORT_FORMAT_FIELD { get; set; }
        public virtual DbSet<EXPORT_FORMAT_RESULT> EXPORT_FORMAT_RESULT { get; set; }
        public virtual DbSet<EXPORT_FORMAT_ROW> EXPORT_FORMAT_ROW { get; set; }
        public virtual DbSet<FAMILY> FAMILies { get; set; }
        public virtual DbSet<FAMILY_MEMBER> FAMILY_MEMBER { get; set; }
        public virtual DbSet<FIELD_SET> FIELD_SET { get; set; }
        public virtual DbSet<FIELD_SET_MEMBER> FIELD_SET_MEMBER { get; set; }
        public virtual DbSet<FILTER> FILTERs { get; set; }
        public virtual DbSet<FOLDER_FILE> FOLDER_FILE { get; set; }
        public virtual DbSet<FOLDER_FILE_PAGE> FOLDER_FILE_PAGE { get; set; }
        public virtual DbSet<FORM_DEFINITION> FORM_DEFINITION { get; set; }
        public virtual DbSet<FORM_INSTANCE> FORM_INSTANCE { get; set; }
        public virtual DbSet<FORUM_POST> FORUM_POST { get; set; }
        public virtual DbSet<FORUM_TOPIC> FORUM_TOPIC { get; set; }
        public virtual DbSet<FORUM_TOPIC_VIEW> FORUM_TOPIC_VIEW { get; set; }
        public virtual DbSet<FUTURE_STUDENT_CAPACITY> FUTURE_STUDENT_CAPACITY { get; set; }
        public virtual DbSet<GENERIC_FORM_CHILD_DATA> GENERIC_FORM_CHILD_DATA { get; set; }
        public virtual DbSet<GENERIC_FORM_DATA> GENERIC_FORM_DATA { get; set; }
        public virtual DbSet<GOOGLE_DOCUMENT_INSTANCE> GOOGLE_DOCUMENT_INSTANCE { get; set; }
        public virtual DbSet<GRADE_GPA_DEFINITION> GRADE_GPA_DEFINITION { get; set; }
        public virtual DbSet<GRADE_GPA_HISTORY> GRADE_GPA_HISTORY { get; set; }
        public virtual DbSet<GRADE_GPA_MEMBER_COURSE> GRADE_GPA_MEMBER_COURSE { get; set; }
        public virtual DbSet<GRADE_GPA_MEMBER_GRADE> GRADE_GPA_MEMBER_GRADE { get; set; }
        public virtual DbSet<GRADE_POST> GRADE_POST { get; set; }
        public virtual DbSet<GRADE_POST_CONTROL> GRADE_POST_CONTROL { get; set; }
        public virtual DbSet<GRADE_SCALE> GRADE_SCALE { get; set; }
        public virtual DbSet<GRADE_SCALE_GRADE_DEFINITION> GRADE_SCALE_GRADE_DEFINITION { get; set; }
        public virtual DbSet<GRADE_SCALE_POINTS> GRADE_SCALE_POINTS { get; set; }
        public virtual DbSet<GRADE_TERM> GRADE_TERM { get; set; }
        public virtual DbSet<GRADE_TERM_DATE> GRADE_TERM_DATE { get; set; }
        public virtual DbSet<GRADE_TERM_DEFINITION> GRADE_TERM_DEFINITION { get; set; }
        public virtual DbSet<GRADE_TRANS_COLUMN_DEFINITION> GRADE_TRANS_COLUMN_DEFINITION { get; set; }
        public virtual DbSet<GRADE_TRANSCRIPT_DEFINITION> GRADE_TRANSCRIPT_DEFINITION { get; set; }
        public virtual DbSet<GRADE_TREND> GRADE_TREND { get; set; }
        public virtual DbSet<GRADEBOOK_ACCESS_GRANT> GRADEBOOK_ACCESS_GRANT { get; set; }
        public virtual DbSet<GRADEBOOK_ACCESS_TRACK> GRADEBOOK_ACCESS_TRACK { get; set; }
        public virtual DbSet<GRADEBOOK_COLUMN_DEFINITION> GRADEBOOK_COLUMN_DEFINITION { get; set; }
        public virtual DbSet<GRADEBOOK_COLUMN_TYPE> GRADEBOOK_COLUMN_TYPE { get; set; }
        public virtual DbSet<GRADEBOOK_COMMENT> GRADEBOOK_COMMENT { get; set; }
        public virtual DbSet<GRADEBOOK_FOOTNOTE> GRADEBOOK_FOOTNOTE { get; set; }
        public virtual DbSet<GRADEBOOK_PREF> GRADEBOOK_PREF { get; set; }
        public virtual DbSet<GRADEBOOK_REMARK> GRADEBOOK_REMARK { get; set; }
        public virtual DbSet<GRADEBOOK_SCORE> GRADEBOOK_SCORE { get; set; }
        public virtual DbSet<GRADEBOOK_SEATING_CHART> GRADEBOOK_SEATING_CHART { get; set; }
        public virtual DbSet<GRADEBOOK_SEATING_POSITION> GRADEBOOK_SEATING_POSITION { get; set; }
        public virtual DbSet<GRADEBOOK_SPECIAL_CODE> GRADEBOOK_SPECIAL_CODE { get; set; }
        public virtual DbSet<GRADEBOOK_STUDENT_INFO> GRADEBOOK_STUDENT_INFO { get; set; }
        public virtual DbSet<GRADEBOOK_STUDENT_SUBMISSION> GRADEBOOK_STUDENT_SUBMISSION { get; set; }
        public virtual DbSet<GRADUATION_COURSE_REQUIREMENT> GRADUATION_COURSE_REQUIREMENT { get; set; }
        public virtual DbSet<GRADUATION_PROGRAM> GRADUATION_PROGRAM { get; set; }
        public virtual DbSet<GRADUATION_REQUIREMENT> GRADUATION_REQUIREMENT { get; set; }
        public virtual DbSet<GRADUATION_REQUIREMENT_HISTORY> GRADUATION_REQUIREMENT_HISTORY { get; set; }
        public virtual DbSet<GRADUATION_STUDENT_PROGRAM> GRADUATION_STUDENT_PROGRAM { get; set; }
        public virtual DbSet<GROUP_EVENT> GROUP_EVENT { get; set; }
        public virtual DbSet<GROUP_MEMBER> GROUP_MEMBER { get; set; }
        public virtual DbSet<GROUP_MEMBER_ATTRIBUTE> GROUP_MEMBER_ATTRIBUTE { get; set; }
        public virtual DbSet<GROUP_MEMBER_CACHE> GROUP_MEMBER_CACHE { get; set; }
        public virtual DbSet<GROUP_PAGE_BANNER> GROUP_PAGE_BANNER { get; set; }
        public virtual DbSet<GROUP_PAGE_BLOG> GROUP_PAGE_BLOG { get; set; }
        public virtual DbSet<GROUP_PAGE_FORUM> GROUP_PAGE_FORUM { get; set; }
        public virtual DbSet<GROUP_PAGE_LOG> GROUP_PAGE_LOG { get; set; }
        public virtual DbSet<GROUP_PAGE_PREFERENCE> GROUP_PAGE_PREFERENCE { get; set; }
        public virtual DbSet<GROUP_PAGE_TAB> GROUP_PAGE_TAB { get; set; }
        public virtual DbSet<GROUP_PAGE_WIDGET> GROUP_PAGE_WIDGET { get; set; }
        public virtual DbSet<GROUP_SET> GROUP_SET { get; set; }
        public virtual DbSet<GROUP> GROUPS { get; set; }
        public virtual DbSet<HEALTH_CONDITION> HEALTH_CONDITION { get; set; }
        public virtual DbSet<HEALTH_IMMUNIZATION_DEFINITION> HEALTH_IMMUNIZATION_DEFINITION { get; set; }
        public virtual DbSet<HEALTH_IMMUNIZATION_DOSE> HEALTH_IMMUNIZATION_DOSE { get; set; }
        public virtual DbSet<HEALTH_IMMUNIZATION_SERIES> HEALTH_IMMUNIZATION_SERIES { get; set; }
        public virtual DbSet<HEALTH_INVENTORY_TRANSACTION> HEALTH_INVENTORY_TRANSACTION { get; set; }
        public virtual DbSet<HEALTH_JOB> HEALTH_JOB { get; set; }
        public virtual DbSet<HEALTH_LOG> HEALTH_LOG { get; set; }
        public virtual DbSet<HEALTH_LOG_ACTION> HEALTH_LOG_ACTION { get; set; }
        public virtual DbSet<HEALTH_LOG_COMPLAINT> HEALTH_LOG_COMPLAINT { get; set; }
        public virtual DbSet<HEALTH_LOG_TREATMENT> HEALTH_LOG_TREATMENT { get; set; }
        public virtual DbSet<HEALTH_MEDICATION_ORDER> HEALTH_MEDICATION_ORDER { get; set; }
        public virtual DbSet<HEALTH_SCREENING> HEALTH_SCREENING { get; set; }
        public virtual DbSet<IEP_ACCESS_LOG> IEP_ACCESS_LOG { get; set; }
        public virtual DbSet<IEP_AMENDMENT> IEP_AMENDMENT { get; set; }
        public virtual DbSet<IEP_AMENDMENT_DETAIL> IEP_AMENDMENT_DETAIL { get; set; }
        public virtual DbSet<IEP_DATA> IEP_DATA { get; set; }
        public virtual DbSet<IEP_GOAL> IEP_GOAL { get; set; }
        public virtual DbSet<IEP_GOAL_BANK> IEP_GOAL_BANK { get; set; }
        public virtual DbSet<IEP_GOAL_BANK_OBJECTIVE> IEP_GOAL_BANK_OBJECTIVE { get; set; }
        public virtual DbSet<IEP_GOAL_OBJECTIVE> IEP_GOAL_OBJECTIVE { get; set; }
        public virtual DbSet<IEP_GOAL_PROGRESS> IEP_GOAL_PROGRESS { get; set; }
        public virtual DbSet<IEP_MEETING> IEP_MEETING { get; set; }
        public virtual DbSet<IEP_MEETING_ATTENDANCE> IEP_MEETING_ATTENDANCE { get; set; }
        public virtual DbSet<IEP_OTHER_SERVICE> IEP_OTHER_SERVICE { get; set; }
        public virtual DbSet<IEP_PERFORMANCE_LEVEL> IEP_PERFORMANCE_LEVEL { get; set; }
        public virtual DbSet<IEP_PERFORMANCE_SOURCE> IEP_PERFORMANCE_SOURCE { get; set; }
        public virtual DbSet<IEP_PLACEMENT> IEP_PLACEMENT { get; set; }
        public virtual DbSet<IEP_PLACEMENT_PROGRAM> IEP_PLACEMENT_PROGRAM { get; set; }
        public virtual DbSet<IEP_SERVICE> IEP_SERVICE { get; set; }
        public virtual DbSet<IEP_SERVICE_FTE> IEP_SERVICE_FTE { get; set; }
        public virtual DbSet<IEP_SERVICE_GOAL_ALIGNMENT> IEP_SERVICE_GOAL_ALIGNMENT { get; set; }
        public virtual DbSet<IEP_SERVICE_LOG> IEP_SERVICE_LOG { get; set; }
        public virtual DbSet<IEP_TEAM_MEMBER> IEP_TEAM_MEMBER { get; set; }
        public virtual DbSet<IMPORT_EXPORT_DEFINITION> IMPORT_EXPORT_DEFINITION { get; set; }
        public virtual DbSet<JOB_ENTRY> JOB_ENTRY { get; set; }
        public virtual DbSet<JOB_RESULT> JOB_RESULT { get; set; }
        public virtual DbSet<JOURNAL_CREDIT_ITEM> JOURNAL_CREDIT_ITEM { get; set; }
        public virtual DbSet<JOURNAL_DEBIT_ITEM> JOURNAL_DEBIT_ITEM { get; set; }
        public virtual DbSet<JOURNAL_ENTRY_CREDIT> JOURNAL_ENTRY_CREDIT { get; set; }
        public virtual DbSet<JOURNAL_ENTRY_DEBIT> JOURNAL_ENTRY_DEBIT { get; set; }
        public virtual DbSet<LEARNING_STANDARD> LEARNING_STANDARD { get; set; }
        public virtual DbSet<LICENSE> LICENSEs { get; set; }
        public virtual DbSet<LOCAL_REPOSITORY> LOCAL_REPOSITORY { get; set; }
        public virtual DbSet<MESSAGE_RESOURCE> MESSAGE_RESOURCE { get; set; }
        public virtual DbSet<OAUTH_TOKEN> OAUTH_TOKEN { get; set; }
        public virtual DbSet<ORGANIZATION> ORGANIZATIONs { get; set; }
        public virtual DbSet<ORGANIZATION_ATTRIBUTES> ORGANIZATION_ATTRIBUTES { get; set; }
        public virtual DbSet<ORGANIZATION_DEFINITION> ORGANIZATION_DEFINITION { get; set; }
        public virtual DbSet<ORGANIZATION_LOCALE> ORGANIZATION_LOCALE { get; set; }
        public virtual DbSet<PAGE_MENU_ITEM> PAGE_MENU_ITEM { get; set; }
        public virtual DbSet<PD_ACTIVITY_COURSE> PD_ACTIVITY_COURSE { get; set; }
        public virtual DbSet<PD_ACTIVITY_GOAL_ALIGNMENT> PD_ACTIVITY_GOAL_ALIGNMENT { get; set; }
        public virtual DbSet<PD_ACTIVITY_SECTION> PD_ACTIVITY_SECTION { get; set; }
        public virtual DbSet<PD_ACTIVITY_SECTION_MEETING> PD_ACTIVITY_SECTION_MEETING { get; set; }
        public virtual DbSet<PD_GOAL> PD_GOAL { get; set; }
        public virtual DbSet<PERSON> People { get; set; }
        public virtual DbSet<PERSON_ADDRESS> PERSON_ADDRESS { get; set; }
        public virtual DbSet<PERSON_APPOINTMENT> PERSON_APPOINTMENT { get; set; }
        public virtual DbSet<PERSON_DOCUMENT> PERSON_DOCUMENT { get; set; }
        public virtual DbSet<PERSON_PHOTO> PERSON_PHOTO { get; set; }
        public virtual DbSet<PERSON_RACE> PERSON_RACE { get; set; }
        public virtual DbSet<PLANNER_APPOINTMENT> PLANNER_APPOINTMENT { get; set; }
        public virtual DbSet<PORTAL_LINK> PORTAL_LINK { get; set; }
        public virtual DbSet<PORTAL_NOTICE> PORTAL_NOTICE { get; set; }
        public virtual DbSet<PORTAL_NOTICE_VISIBILITY> PORTAL_NOTICE_VISIBILITY { get; set; }
        public virtual DbSet<PROCEDURE_INFO> PROCEDURE_INFO { get; set; }
        public virtual DbSet<QUERY_OPERATOR> QUERY_OPERATOR { get; set; }
        public virtual DbSet<QUESTION_SET_DEFINITION> QUESTION_SET_DEFINITION { get; set; }
        public virtual DbSet<QUESTION_SET_INSTANCE> QUESTION_SET_INSTANCE { get; set; }
        public virtual DbSet<QUESTION_SET_ITEM> QUESTION_SET_ITEM { get; set; }
        public virtual DbSet<QUESTION_SET_QUESTION> QUESTION_SET_QUESTION { get; set; }
        public virtual DbSet<QUESTION_SET_QUESTION_CHOICE> QUESTION_SET_QUESTION_CHOICE { get; set; }
        public virtual DbSet<QUESTION_SET_RESPONSE> QUESTION_SET_RESPONSE { get; set; }
        public virtual DbSet<QUESTION_STANDARD> QUESTION_STANDARD { get; set; }
        public virtual DbSet<QUOTA_USAGE_ANALYSIS> QUOTA_USAGE_ANALYSIS { get; set; }
        public virtual DbSet<RECOMMENDATION_CONTROLS> RECOMMENDATION_CONTROLS { get; set; }
        public virtual DbSet<RECORD_SET> RECORD_SET { get; set; }
        public virtual DbSet<RECORD_SET_KEY> RECORD_SET_KEY { get; set; }
        public virtual DbSet<REF_ATTENDANCE_STAFF> REF_ATTENDANCE_STAFF { get; set; }
        public virtual DbSet<REF_ATTENDANCE_STUDENT> REF_ATTENDANCE_STUDENT { get; set; }
        public virtual DbSet<REF_CODE> REF_CODE { get; set; }
        public virtual DbSet<REF_CODE_HIDE> REF_CODE_HIDE { get; set; }
        public virtual DbSet<REF_CODE_REQUIRED_FIELD> REF_CODE_REQUIRED_FIELD { get; set; }
        public virtual DbSet<REF_QAN_CODE> REF_QAN_CODE { get; set; }
        public virtual DbSet<REF_TABLE> REF_TABLE { get; set; }
        public virtual DbSet<REGEX_LIBRARY> REGEX_LIBRARY { get; set; }
        public virtual DbSet<REMOTE_REPOSITORY> REMOTE_REPOSITORY { get; set; }
        public virtual DbSet<REMOTE_REPOSITORY_ACCESS> REMOTE_REPOSITORY_ACCESS { get; set; }
        public virtual DbSet<REMOTE_REPOSITORY_TYPE> REMOTE_REPOSITORY_TYPE { get; set; }
        public virtual DbSet<REPORT> REPORTs { get; set; }
        public virtual DbSet<REPORT_DELIVERY_JOB> REPORT_DELIVERY_JOB { get; set; }
        public virtual DbSet<REPORT_DELIVERY_RECIPIENT> REPORT_DELIVERY_RECIPIENT { get; set; }
        public virtual DbSet<REPORT_WIZARD> REPORT_WIZARD { get; set; }
        public virtual DbSet<REPORTING_STANDARD_ASSIGNMENT> REPORTING_STANDARD_ASSIGNMENT { get; set; }
        public virtual DbSet<REPORTING_STANDARD_SCORE> REPORTING_STANDARD_SCORE { get; set; }
        public virtual DbSet<REPORTING_STANDARD_WEIGHT> REPORTING_STANDARD_WEIGHT { get; set; }
        public virtual DbSet<RUBRIC_ASSESSMENT> RUBRIC_ASSESSMENT { get; set; }
        public virtual DbSet<RUBRIC_ASSESSMENT_PERFORMANCE> RUBRIC_ASSESSMENT_PERFORMANCE { get; set; }
        public virtual DbSet<RUBRIC_CRITERION> RUBRIC_CRITERION { get; set; }
        public virtual DbSet<RUBRIC_DEFINITION> RUBRIC_DEFINITION { get; set; }
        public virtual DbSet<RUBRIC_GRADE_LEVEL> RUBRIC_GRADE_LEVEL { get; set; }
        public virtual DbSet<RUBRIC_LEARNING_STANDARD> RUBRIC_LEARNING_STANDARD { get; set; }
        public virtual DbSet<RUBRIC_PERFORMANCE_DESCRIPTOR> RUBRIC_PERFORMANCE_DESCRIPTOR { get; set; }
        public virtual DbSet<RUBRIC_RATING_SCALE> RUBRIC_RATING_SCALE { get; set; }
        public virtual DbSet<RUBRIC_RATING_SCALE_POINTS> RUBRIC_RATING_SCALE_POINTS { get; set; }
        public virtual DbSet<SAVED_QUERY> SAVED_QUERY { get; set; }
        public virtual DbSet<SCHEDULE> SCHEDULEs { get; set; }
        public virtual DbSet<SCHEDULE_BELL> SCHEDULE_BELL { get; set; }
        public virtual DbSet<SCHEDULE_BELL_DAY> SCHEDULE_BELL_DAY { get; set; }
        public virtual DbSet<SCHEDULE_BELL_PERIOD> SCHEDULE_BELL_PERIOD { get; set; }
        public virtual DbSet<SCHEDULE_BUILD_CLASS> SCHEDULE_BUILD_CLASS { get; set; }
        public virtual DbSet<SCHEDULE_BUILD_MASTER> SCHEDULE_BUILD_MASTER { get; set; }
        public virtual DbSet<SCHEDULE_BUILD_ROOM> SCHEDULE_BUILD_ROOM { get; set; }
        public virtual DbSet<SCHEDULE_BUILD_STUDENT> SCHEDULE_BUILD_STUDENT { get; set; }
        public virtual DbSet<SCHEDULE_BUILD_TEACHER> SCHEDULE_BUILD_TEACHER { get; set; }
        public virtual DbSet<SCHEDULE_CLASS> SCHEDULE_CLASS { get; set; }
        public virtual DbSet<SCHEDULE_CLASS_MATRIX> SCHEDULE_CLASS_MATRIX { get; set; }
        public virtual DbSet<SCHEDULE_CLASS_TERM> SCHEDULE_CLASS_TERM { get; set; }
        public virtual DbSet<SCHEDULE_COMMIT> SCHEDULE_COMMIT { get; set; }
        public virtual DbSet<SCHEDULE_COMMIT_CONTROL> SCHEDULE_COMMIT_CONTROL { get; set; }
        public virtual DbSet<SCHEDULE_DAY> SCHEDULE_DAY { get; set; }
        public virtual DbSet<SCHEDULE_FEEDBACK> SCHEDULE_FEEDBACK { get; set; }
        public virtual DbSet<SCHEDULE_MASTER> SCHEDULE_MASTER { get; set; }
        public virtual DbSet<SCHEDULE_MASTER_MATRIX> SCHEDULE_MASTER_MATRIX { get; set; }
        public virtual DbSet<SCHEDULE_MASTER_TEACHER> SCHEDULE_MASTER_TEACHER { get; set; }
        public virtual DbSet<SCHEDULE_MASTER_TEACHER_MATRIX> SCHEDULE_MASTER_TEACHER_MATRIX { get; set; }
        public virtual DbSet<SCHEDULE_MASTER_TERM> SCHEDULE_MASTER_TERM { get; set; }
        public virtual DbSet<SCHEDULE_MATRIX> SCHEDULE_MATRIX { get; set; }
        public virtual DbSet<SCHEDULE_PATTERN_LIBRARY> SCHEDULE_PATTERN_LIBRARY { get; set; }
        public virtual DbSet<SCHEDULE_PATTERN_SET> SCHEDULE_PATTERN_SET { get; set; }
        public virtual DbSet<SCHEDULE_PATTERN_SET_MEMBER> SCHEDULE_PATTERN_SET_MEMBER { get; set; }
        public virtual DbSet<SCHEDULE_PERIOD> SCHEDULE_PERIOD { get; set; }
        public virtual DbSet<SCHEDULE_PREF> SCHEDULE_PREF { get; set; }
        public virtual DbSet<SCHEDULE_PREF_DEFINITION> SCHEDULE_PREF_DEFINITION { get; set; }
        public virtual DbSet<SCHEDULE_ROTATION> SCHEDULE_ROTATION { get; set; }
        public virtual DbSet<SCHEDULE_ROTATION_MAP> SCHEDULE_ROTATION_MAP { get; set; }
        public virtual DbSet<SCHEDULE_RULE> SCHEDULE_RULE { get; set; }
        public virtual DbSet<SCHEDULE_RULE_DEFINITION> SCHEDULE_RULE_DEFINITION { get; set; }
        public virtual DbSet<SCHEDULE_RULE_OBJECT> SCHEDULE_RULE_OBJECT { get; set; }
        public virtual DbSet<SCHEDULE_RULE_OBJECT_DEF> SCHEDULE_RULE_OBJECT_DEF { get; set; }
        public virtual DbSet<SCHEDULE_TERM> SCHEDULE_TERM { get; set; }
        public virtual DbSet<SCHEDULE_TERM_DATE> SCHEDULE_TERM_DATE { get; set; }
        public virtual DbSet<SCHOOL> SCHOOLs { get; set; }
        public virtual DbSet<SCHOOL_ATTRIBUTES> SCHOOL_ATTRIBUTES { get; set; }
        public virtual DbSet<SCHOOL_CAPACITY> SCHOOL_CAPACITY { get; set; }
        public virtual DbSet<SCHOOL_GRID_CODE> SCHOOL_GRID_CODE { get; set; }
        public virtual DbSet<SCHOOL_LOCKER> SCHOOL_LOCKER { get; set; }
        public virtual DbSet<SCHOOL_ROOM> SCHOOL_ROOM { get; set; }
        public virtual DbSet<SCHOOL_SCHEDULE_CONTEXT> SCHOOL_SCHEDULE_CONTEXT { get; set; }
        public virtual DbSet<SCHOOL_STANDARD> SCHOOL_STANDARD { get; set; }
        public virtual DbSet<SECTION_REPORTING_STANDARD> SECTION_REPORTING_STANDARD { get; set; }
        public virtual DbSet<SECURITY_ACCESS> SECURITY_ACCESS { get; set; }
        public virtual DbSet<SECURITY_CONTEXT> SECURITY_CONTEXT { get; set; }
        public virtual DbSet<SECURITY_PRIVILEGE> SECURITY_PRIVILEGE { get; set; }
        public virtual DbSet<SECURITY_ROLE> SECURITY_ROLE { get; set; }
        public virtual DbSet<SECURITY_TAG> SECURITY_TAG { get; set; }
        public virtual DbSet<SECURITY_TAG_ACCESS> SECURITY_TAG_ACCESS { get; set; }
        public virtual DbSet<SECURITY_TAG_FIELD> SECURITY_TAG_FIELD { get; set; }
        public virtual DbSet<SELECTION> SELECTIONs { get; set; }
        public virtual DbSet<SELECTION_OBJECT> SELECTION_OBJECT { get; set; }
        public virtual DbSet<SERVICE_PROVIDER> SERVICE_PROVIDER { get; set; }
        public virtual DbSet<SERVICE_PROVIDER_TYPE> SERVICE_PROVIDER_TYPE { get; set; }
        public virtual DbSet<SORT_ORDER> SORT_ORDER { get; set; }
        public virtual DbSet<SORT_ORDER_FIELD> SORT_ORDER_FIELD { get; set; }
        public virtual DbSet<STAFF> STAFFs { get; set; }
        public virtual DbSet<STAFF_ACCRUAL> STAFF_ACCRUAL { get; set; }
        public virtual DbSet<STAFF_ACTIVITY> STAFF_ACTIVITY { get; set; }
        public virtual DbSet<STAFF_ATTENDANCE> STAFF_ATTENDANCE { get; set; }
        public virtual DbSet<STAFF_ATTENDANCE_SUB> STAFF_ATTENDANCE_SUB { get; set; }
        public virtual DbSet<STAFF_CERTIFICATION> STAFF_CERTIFICATION { get; set; }
        public virtual DbSet<STAFF_COURSE_WORK> STAFF_COURSE_WORK { get; set; }
        public virtual DbSet<STAFF_DEGREE> STAFF_DEGREE { get; set; }
        public virtual DbSet<STAFF_LEAVE> STAFF_LEAVE { get; set; }
        public virtual DbSet<STAFF_PD_ACTION_GOAL_ALIGN> STAFF_PD_ACTION_GOAL_ALIGN { get; set; }
        public virtual DbSet<STAFF_PD_ACTION_PLAN> STAFF_PD_ACTION_PLAN { get; set; }
        public virtual DbSet<STAFF_PD_ACTIVITY> STAFF_PD_ACTIVITY { get; set; }
        public virtual DbSet<STAFF_PD_ACTIVITY_ACTION_ALIGN> STAFF_PD_ACTIVITY_ACTION_ALIGN { get; set; }
        public virtual DbSet<STAFF_PD_ACTIVITY_APPROVAL> STAFF_PD_ACTIVITY_APPROVAL { get; set; }
        public virtual DbSet<STAFF_PD_ACTIVITY_ATTENDANCE> STAFF_PD_ACTIVITY_ATTENDANCE { get; set; }
        public virtual DbSet<STAFF_PD_ACTIVITY_LOG> STAFF_PD_ACTIVITY_LOG { get; set; }
        public virtual DbSet<STAFF_PD_ACTIVITY_REQUEST> STAFF_PD_ACTIVITY_REQUEST { get; set; }
        public virtual DbSet<STAFF_PD_ACTIVITY_VERIFICATION> STAFF_PD_ACTIVITY_VERIFICATION { get; set; }
        public virtual DbSet<STAFF_PD_PLAN> STAFF_PD_PLAN { get; set; }
        public virtual DbSet<STAFF_PD_PLAN_GOAL> STAFF_PD_PLAN_GOAL { get; set; }
        public virtual DbSet<STAFF_PD_PLAN_GOAL_ALIGN> STAFF_PD_PLAN_GOAL_ALIGN { get; set; }
        public virtual DbSet<STAFF_PD_PLAN_REVIEW> STAFF_PD_PLAN_REVIEW { get; set; }
        public virtual DbSet<STAFF_POSITION> STAFF_POSITION { get; set; }
        public virtual DbSet<STAFF_POST_ATTENDANCE> STAFF_POST_ATTENDANCE { get; set; }
        public virtual DbSet<STAFF_SCHEDULE_ASSIGNMENT> STAFF_SCHEDULE_ASSIGNMENT { get; set; }
        public virtual DbSet<STAFF_SCHEDULE_ATTRIBUTES> STAFF_SCHEDULE_ATTRIBUTES { get; set; }
        public virtual DbSet<STAFF_SCHOOL> STAFF_SCHOOL { get; set; }
        public virtual DbSet<STAFF_STANDARD> STAFF_STANDARD { get; set; }
        public virtual DbSet<STAFF_SUPPORT> STAFF_SUPPORT { get; set; }
        public virtual DbSet<STUDENT_ACCOMMODATION> STUDENT_ACCOMMODATION { get; set; }
        public virtual DbSet<STUDENT_ALERT> STUDENT_ALERT { get; set; }
        public virtual DbSet<STUDENT_ASSESSMENT> STUDENT_ASSESSMENT { get; set; }
        public virtual DbSet<STUDENT_ASSESSMENT_RESPONSE> STUDENT_ASSESSMENT_RESPONSE { get; set; }
        public virtual DbSet<STUDENT_ATTENDANCE> STUDENT_ATTENDANCE { get; set; }
        public virtual DbSet<STUDENT_ATTENDANCE_BATCH> STUDENT_ATTENDANCE_BATCH { get; set; }
        public virtual DbSet<STUDENT_ATTENDANCE_TIME> STUDENT_ATTENDANCE_TIME { get; set; }
        public virtual DbSet<STUDENT_CASE> STUDENT_CASE { get; set; }
        public virtual DbSet<STUDENT_CASE_CHILD> STUDENT_CASE_CHILD { get; set; }
        public virtual DbSet<STUDENT_CASE_PERSON> STUDENT_CASE_PERSON { get; set; }
        public virtual DbSet<STUDENT_CONDUCT_ACTION> STUDENT_CONDUCT_ACTION { get; set; }
        public virtual DbSet<STUDENT_CONDUCT_ACTION_DATE> STUDENT_CONDUCT_ACTION_DATE { get; set; }
        public virtual DbSet<STUDENT_CONDUCT_INCIDENT> STUDENT_CONDUCT_INCIDENT { get; set; }
        public virtual DbSet<STUDENT_CONDUCT_OFFENSE> STUDENT_CONDUCT_OFFENSE { get; set; }
        public virtual DbSet<STUDENT_CONTACT> STUDENT_CONTACT { get; set; }
        public virtual DbSet<STUDENT_COURSE_REQUEST> STUDENT_COURSE_REQUEST { get; set; }
        public virtual DbSet<STUDENT_CREDIT_ADJUSTMENT> STUDENT_CREDIT_ADJUSTMENT { get; set; }
        public virtual DbSet<STUDENT_DISABILITY> STUDENT_DISABILITY { get; set; }
        public virtual DbSet<STUDENT_ED_PLAN> STUDENT_ED_PLAN { get; set; }
        public virtual DbSet<STUDENT_ED_PLAN_ASSESSMENT> STUDENT_ED_PLAN_ASSESSMENT { get; set; }
        public virtual DbSet<STUDENT_ED_PLAN_COURSE> STUDENT_ED_PLAN_COURSE { get; set; }
        public virtual DbSet<STUDENT_ED_PLAN_EVALUATION> STUDENT_ED_PLAN_EVALUATION { get; set; }
        public virtual DbSet<STUDENT_ED_PLAN_JOURNAL> STUDENT_ED_PLAN_JOURNAL { get; set; }
        public virtual DbSet<STUDENT_ED_PLAN_MEETING> STUDENT_ED_PLAN_MEETING { get; set; }
        public virtual DbSet<STUDENT_ED_PLAN_MEETING_PART> STUDENT_ED_PLAN_MEETING_PART { get; set; }
        public virtual DbSet<STUDENT_ED_PLAN_TRANSCRIPT> STUDENT_ED_PLAN_TRANSCRIPT { get; set; }
        public virtual DbSet<STUDENT_ENROLLMENT> STUDENT_ENROLLMENT { get; set; }
        public virtual DbSet<STUDENT_EVENT_TRACKING> STUDENT_EVENT_TRACKING { get; set; }
        public virtual DbSet<STUDENT_FEE> STUDENT_FEE { get; set; }
        public virtual DbSet<STUDENT_GRADE_POINT> STUDENT_GRADE_POINT { get; set; }
        public virtual DbSet<STUDENT_GRADE_POINT_ADJUSTMENT> STUDENT_GRADE_POINT_ADJUSTMENT { get; set; }
        public virtual DbSet<STUDENT_JOURNAL> STUDENT_JOURNAL { get; set; }
        public virtual DbSet<STUDENT_LUNCH> STUDENT_LUNCH { get; set; }
        public virtual DbSet<STUDENT_PERIOD_ATTENDANCE> STUDENT_PERIOD_ATTENDANCE { get; set; }
        public virtual DbSet<STUDENT_PROGRAM_DETAIL> STUDENT_PROGRAM_DETAIL { get; set; }
        public virtual DbSet<STUDENT_PROGRAM_PARTICIPATION> STUDENT_PROGRAM_PARTICIPATION { get; set; }
        public virtual DbSet<STUDENT_QUALIFICATION_LIST> STUDENT_QUALIFICATION_LIST { get; set; }
        public virtual DbSet<STUDENT_REQUEST_ADJUSTMENT> STUDENT_REQUEST_ADJUSTMENT { get; set; }
        public virtual DbSet<STUDENT_REQUEST_TRANSACTION> STUDENT_REQUEST_TRANSACTION { get; set; }
        public virtual DbSet<STUDENT_SCHEDULE> STUDENT_SCHEDULE { get; set; }
        public virtual DbSet<STUDENT_SCHEDULE_ATTRIBUTES> STUDENT_SCHEDULE_ATTRIBUTES { get; set; }
        public virtual DbSet<STUDENT_SCHEDULE_CHANGE> STUDENT_SCHEDULE_CHANGE { get; set; }
        public virtual DbSet<STUDENT_SCHEDULE_CHANGE_MATRIX> STUDENT_SCHEDULE_CHANGE_MATRIX { get; set; }
        public virtual DbSet<STUDENT_SCHEDULE_CHANGE_TERM> STUDENT_SCHEDULE_CHANGE_TERM { get; set; }
        public virtual DbSet<STUDENT_SCHEDULE_GROUP> STUDENT_SCHEDULE_GROUP { get; set; }
        public virtual DbSet<STUDENT_SCHEDULE_MATRIX> STUDENT_SCHEDULE_MATRIX { get; set; }
        public virtual DbSet<STUDENT_SCHEDULE_TERM> STUDENT_SCHEDULE_TERM { get; set; }
        public virtual DbSet<STUDENT_SCHOOL> STUDENT_SCHOOL { get; set; }
        public virtual DbSet<STUDENT_SCHOOL_CHOICE> STUDENT_SCHOOL_CHOICE { get; set; }
        public virtual DbSet<STUDENT_TRANSCRIPT> STUDENT_TRANSCRIPT { get; set; }
        public virtual DbSet<STUDENT_TRANSCRIPT_RUBRIC> STUDENT_TRANSCRIPT_RUBRIC { get; set; }
        public virtual DbSet<STUDENT_TRANSPORTATION> STUDENT_TRANSPORTATION { get; set; }
        public virtual DbSet<STUDENT_TRANSPORTATION_SESSION> STUDENT_TRANSPORTATION_SESSION { get; set; }
        public virtual DbSet<STUDENT_VERSION_HISTORY> STUDENT_VERSION_HISTORY { get; set; }
        public virtual DbSet<STUDENT_WAIT_LIST> STUDENT_WAIT_LIST { get; set; }
        public virtual DbSet<SUBSCRIPTION> SUBSCRIPTIONs { get; set; }
        public virtual DbSet<SUBSCRIPTION_DEFINITION> SUBSCRIPTION_DEFINITION { get; set; }
        public virtual DbSet<SYS_CONFIG> SYS_CONFIG { get; set; }
        public virtual DbSet<SYS_PREFERENCE> SYS_PREFERENCE { get; set; }
        public virtual DbSet<SYS_PREFERENCE_DEFINITION> SYS_PREFERENCE_DEFINITION { get; set; }
        public virtual DbSet<TARGET_GRADE> TARGET_GRADE { get; set; }
        public virtual DbSet<TARGET_GRADE_ADJUSTED> TARGET_GRADE_ADJUSTED { get; set; }
        public virtual DbSet<TOOL_NAV> TOOL_NAV { get; set; }
        public virtual DbSet<TOOL_ROLE> TOOL_ROLE { get; set; }
        public virtual DbSet<TOOL_SCHOOL> TOOL_SCHOOL { get; set; }
        public virtual DbSet<TRANSPORTATION_RESOURCE> TRANSPORTATION_RESOURCE { get; set; }
        public virtual DbSet<USER_ACCESS_LOG> USER_ACCESS_LOG { get; set; }
        public virtual DbSet<USER_INFO> USER_INFO { get; set; }
        public virtual DbSet<USER_ORGANIZATION> USER_ORGANIZATION { get; set; }
        public virtual DbSet<USER_ROLE> USER_ROLE { get; set; }
        public virtual DbSet<USER_ROLE_SCHOOL> USER_ROLE_SCHOOL { get; set; }
        public virtual DbSet<USER_SCHOOL> USER_SCHOOL { get; set; }
        public virtual DbSet<USER_TOOL_LOG> USER_TOOL_LOG { get; set; }
        public virtual DbSet<VIEW_TEMPLATE> VIEW_TEMPLATE { get; set; }
        public virtual DbSet<WIDGET_DEFINITION> WIDGET_DEFINITION { get; set; }
        public virtual DbSet<WORKFLOW> WORKFLOWs { get; set; }
        public virtual DbSet<WORKFLOW_ACCESS> WORKFLOW_ACCESS { get; set; }
        public virtual DbSet<WORKFLOW_COMPLIANCE_RULE> WORKFLOW_COMPLIANCE_RULE { get; set; }
        public virtual DbSet<WORKFLOW_DEFINITION> WORKFLOW_DEFINITION { get; set; }
        public virtual DbSet<WORKFLOW_PARTICIPANT> WORKFLOW_PARTICIPANT { get; set; }
        public virtual DbSet<WORKFLOW_PHASE> WORKFLOW_PHASE { get; set; }
        public virtual DbSet<WORKFLOW_PHASE_OUTCOME> WORKFLOW_PHASE_OUTCOME { get; set; }
        public virtual DbSet<WORKFLOW_PHASE_OUTCOME_FORM> WORKFLOW_PHASE_OUTCOME_FORM { get; set; }
        public virtual DbSet<WORKFLOW_PROGRESS> WORKFLOW_PROGRESS { get; set; }
        public virtual DbSet<WORKFLOW_PROGRESS_FORM> WORKFLOW_PROGRESS_FORM { get; set; }
        public virtual DbSet<WORKFLOW_ROLE> WORKFLOW_ROLE { get; set; }
        public virtual DbSet<WORKFLOW_ROLE_USER> WORKFLOW_ROLE_USER { get; set; }
        public virtual DbSet<Z_CONFIG> Z_CONFIG { get; set; }
        public virtual DbSet<Z_CONVERSION> Z_CONVERSION { get; set; }
        public virtual DbSet<Z_CONVERSION_FIELD_STAT> Z_CONVERSION_FIELD_STAT { get; set; }
        public virtual DbSet<Z_CONVERSION_LOG_ENTRY> Z_CONVERSION_LOG_ENTRY { get; set; }
        public virtual DbSet<Z_CONVERSION_TABLE_STAT> Z_CONVERSION_TABLE_STAT { get; set; }
        public virtual DbSet<Z_EXPRESSION> Z_EXPRESSION { get; set; }
        public virtual DbSet<Z_JOB> Z_JOB { get; set; }
        public virtual DbSet<Z_JOB_MAP_TABLE> Z_JOB_MAP_TABLE { get; set; }
        public virtual DbSet<Z_JOB_PROCEDURE> Z_JOB_PROCEDURE { get; set; }
        public virtual DbSet<Z_MAP_FIELD> Z_MAP_FIELD { get; set; }
        public virtual DbSet<Z_MAP_REFERENCE> Z_MAP_REFERENCE { get; set; }
        public virtual DbSet<Z_MAP_TABLE> Z_MAP_TABLE { get; set; }
        public virtual DbSet<Z_PROCEDURE> Z_PROCEDURE { get; set; }
        public virtual DbSet<DBVersion> DBVersions { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
    
        public virtual ObjectResult<FindDataTypeMismatch_Result> FindDataTypeMismatch(string parentTable, string fK, string childTable, string pK)
        {
            var parentTableParameter = parentTable != null ?
                new ObjectParameter("ParentTable", parentTable) :
                new ObjectParameter("ParentTable", typeof(string));
    
            var fKParameter = fK != null ?
                new ObjectParameter("FK", fK) :
                new ObjectParameter("FK", typeof(string));
    
            var childTableParameter = childTable != null ?
                new ObjectParameter("ChildTable", childTable) :
                new ObjectParameter("ChildTable", typeof(string));
    
            var pKParameter = pK != null ?
                new ObjectParameter("PK", pK) :
                new ObjectParameter("PK", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FindDataTypeMismatch_Result>("FindDataTypeMismatch", parentTableParameter, fKParameter, childTableParameter, pKParameter);
        }
    
        public virtual int IndexFragList(Nullable<int> numberToReindex, Nullable<bool> performReindex)
        {
            var numberToReindexParameter = numberToReindex.HasValue ?
                new ObjectParameter("numberToReindex", numberToReindex) :
                new ObjectParameter("numberToReindex", typeof(int));
    
            var performReindexParameter = performReindex.HasValue ?
                new ObjectParameter("performReindex", performReindex) :
                new ObjectParameter("performReindex", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("IndexFragList", numberToReindexParameter, performReindexParameter);
        }
    }
}
