using System.ComponentModel.DataAnnotations;

public class WebHookSettings
{
    [Required, Url]
    public string? WebhookUrl { get; set; } = default;

    [Required]
    public string? DisplayName { get; set; } = default;

    public bool Enabled { get; set; }

    [Required]
    [Range(0, 3,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int RetryTimes { get; set; }
}