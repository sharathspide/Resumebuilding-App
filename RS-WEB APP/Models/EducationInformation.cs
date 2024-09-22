namespace RS_WEB_APP.Models
{
    public class EducationInformation
    {
        public List<Educations> educationList {  get; set; }
        /// <summary>
        /// Maps the UserID of the Particular user
        /// </summary>
        public string UserId {  get; set; }
    }

    public class Educations
    {
        public string schoolName { get; set; }
        public string schoolDescription { get; set;}
        public string collegeName { get; set; }
        public string collegeDescription { get; set; }
        public string majorCourse { get; set;}
        public string Percentage { get; set;}
        public string yearOfCompletion { get; set;}
    }
}