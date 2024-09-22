namespace RS_WEB_APP.Models
{
    public class Skills
    {
        /// <summary>
        /// Maps the UserID of the Particular user
        /// </summary>
        public string UserId { get; set; }
        public List<SkillSet> skillList {  get; set; }
    }

    public class SkillSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string percentage { get; set; }
    }
}