﻿using System.Text.Json.Serialization;

namespace University.API.ViewModels.Teachers
{
    public class GetTopThreeMostPreferredViewModel
    {
        public int Id { get; set; }

        [JsonPropertyName("First name")]
        public string PersonFirstName { get; set; }

        [JsonPropertyName("Second name")]
        public string PersonSecondName { get; set; }

        [JsonPropertyName("Last name")]
        public string PersonLastName { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Enrolled students")]
        public int EnrolledStudentsCount { get; set; }
    }
}
