// Add your Computer Vision key and endpoint
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;

var key = "<your-azure-ai-vision-key>";
var endpoint = "<your-azure-ai-vision-endpoint>";

var imageUrl = "<your-image-url>";

// Create a client
var client = new ComputerVisionClient(new ApiKeyServiceClientCredentials(key)) { Endpoint = endpoint };

var response = await client.GenerateThumbnailAsync(200, 200, imageUrl, smartCropping: false);

// Save thumbnail image
string thumbnailFileName = "thumbnail.png";
using (Stream thumbnailFile = File.Create(thumbnailFileName))
{
    response.CopyTo(thumbnailFile);
}
