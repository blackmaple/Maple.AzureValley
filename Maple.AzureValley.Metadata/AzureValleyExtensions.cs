namespace Maple.AzureValley.Metadata
{
    public class AzureValleyExtensions
    {
        public static AzureValleyEnvironment GetAzureValleyEnvironment(AzureValleyMetadata @this)
            => new(@this);
    }
}
