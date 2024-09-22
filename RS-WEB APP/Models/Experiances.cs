namespace RS_WEB_APP.Models
{
    public class Experiances
    {
        /// <summary>
        /// Maps the UserID of the Particular user
        /// </summary>
        public string UserId { get; set; }
        public List<CompanyInformations> companyInformations {  get; set; }
    }

    public class CompanyInformations
    {
        public string companyName { get; set;}
        public string Designation { get; set;}
        public int yearsOfExperiance { get; set;}
        public string rolesAndResposibilty { get; set;}
    }
}