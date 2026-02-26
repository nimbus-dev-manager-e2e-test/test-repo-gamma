using Microsoft.Extensions.Logging;

namespace Nimbus.TestRepoGamma.Services;

/// <summary>
/// Core service providing shared utilities across the platform.
/// </summary>
public class GammaService
{
    private readonly ILogger<GammaService> _logger;

    public GammaService(ILogger<GammaService> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Validates the input data and returns a result.
    /// </summary>
    public bool ValidateInput(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            _logger.LogWarning("Input validation failed: empty input");
            return false;
        }

        _logger.LogInformation("Input validated successfully: {Length} chars", input.Length);
        return true;
    }

    /// <summary>
    /// Processes a batch of items concurrently.
    /// </summary>
    public async Task<int> ProcessBatchAsync(IEnumerable<string> items, CancellationToken ct = default)
    {
        var count = 0;
        foreach (var item in items)
        {
            ct.ThrowIfCancellationRequested();
            await Task.Delay(10, ct);
            count++;
        }

        _logger.LogInformation("Processed {Count} items", count);
        return count;
    }
}
