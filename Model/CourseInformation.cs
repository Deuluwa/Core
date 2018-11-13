namespace DeuluwaCore.Model
{
    public class CourseInformation
    {
        public string index { get; set; }                   //인덱스
        public string coursename { get; set; }              //수업명
        public string classday { get; set; }                //수업요일
        public string classdayOrigin { get; set; }          //수업요일 원본

        public string coursedate { get; set; }              //진행기간
        public string coursetime { get; set; }              //진행시간
        public string courseStartTimeOrigin { get; set; }   //진행시작시간 원본
        public string courseEndTimeOrigin { get; set; }     //진행종료시간 원본

        public string teacher { get; set; }                 //강사명
        public string roomname { get; set; }                //강의실명
        public string roomindex { get; set; }               //강의실인덱스
        public string teacherid { get; set; }               //강사인덱스
        

        public CourseInformation(System.Collections.Generic.Dictionary<string, string> dict)
        {
            if(dict.ContainsKey("index")) index = dict["index"];
            if (dict.ContainsKey("coursename")) coursename = dict["coursename"];
            if (dict.ContainsKey("roomname")) roomname = dict["roomname"];
            if (dict.ContainsKey("roomindex")) roomindex = dict["roomindex"];
            if (dict.ContainsKey("teacher")) teacher = dict["teacher"];
            if (dict.ContainsKey("teacherindex")) teacherid = dict["teacherindex"];
            if (dict.ContainsKey("classday")) classdayOrigin = dict["classday"];

            classday = Constants.MakeClassDay(dict["classday"]);
            coursedate = dict["startdate"] + " - " + dict["enddate"];
            coursetime = Constants.MakeClassTime(dict["starttime"], dict["endtime"]);
            courseStartTimeOrigin = dict["starttime"];
            courseEndTimeOrigin = dict["endtime"];
        }
    }
}