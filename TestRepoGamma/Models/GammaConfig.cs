namespace Nimbus.TestRepoGamma.Models;

/// <summary>
/// Configuration model for the Gamma service.
/// </summary>
public class GammaConfig
{
    public string Name { get; set; } = string.Empty;
    public int MaxRetries { get; set; } = 3;
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);
    public bool EnableLogging { get; set; } = true;
}
