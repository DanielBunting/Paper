namespace Paper.Models.DTOs
{
    public class UserDto
    {
        public string UserId { get; set; }

        public string AppleSubId { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public SettingsDto Settings { get; set; }

        public List<WorkbookDto> Workbooks { get; set; }

    }
}
