using Newtonsoft.Json;
using xf.exam.users.ViewModels;

namespace xf.exam.users.Models
{
    public class User : NotificationEnabledObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        private string _FirstName;

        [JsonProperty("first_name")]
        public string FirstName
        {
            get => _FirstName;
            set => Set(ref _FirstName, value);
        }

        private string _LastName;

        [JsonProperty("last_name")]
        public string LastName
        {
            get => _LastName;
            set => Set(ref _LastName, value);
        }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("dob")]
        public string DOB { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        private string _Phone;

        [JsonProperty("phone")]
        public string Phone
        {
            get => _Phone;
            set => Set(ref _Phone, value);
        }

        [JsonProperty("website")]
        public string WebSite { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        private string _ProfileImage;
        public string ProfileImage
        {
            get => _ProfileImage;
            set => Set(ref _ProfileImage, value);
        }
    }
}
