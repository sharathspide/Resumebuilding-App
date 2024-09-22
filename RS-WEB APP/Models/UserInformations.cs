namespace RS_WEB_APP.Models
{
    public class UserInformations
    {
        public string _id {  get; set; }
        public PersonalInformation personalInformation {  get; set; }
        public EducationInformation educationInformation { get; set; }
        public Experiances userExperiances { get; set; }
        public Skills skills { get; set; }
        public string website { get; set; }
        public SocialMedia socialMedia { get; set; }
    }
}
