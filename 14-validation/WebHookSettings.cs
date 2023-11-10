using System.ComponentModel.DataAnnotations;

public class WebHookSettings
{
    public const string ConfigurationSectionName = "WebHook";
   
    [Required, Url]
    public string WebhookUrl { get; set; } = string.Empty;

    [Required]
    public string DisplayName { get; set; } = string.Empty;

    public bool Enabled { get; set; }

    [Required]
    [Range(0, 3,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int RetryTimes { get; set; }
}