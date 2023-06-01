namespace Business.Abstract;

public interface IGenerator
{
    /// <summary>
    ///     This method generates a unique identifier (ID).
    /// </summary>
    /// <returns>The generated unique identifier (ID).</returns>
    long GenerateId();

    /// <summary>
    ///     This method generates a male name.
    /// </summary>
    /// <returns>The generated male name.</returns>
    string GenerateMaleName();
}