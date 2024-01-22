using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

[TestFixture]
public class VideoServiceTests
{

    [SetUp]
    public void SetUp()
    {
        // Mocking the IFileReader using Moq
        var _fileReader = new Mock<IFileReader>();

        // Creating an instance of VideoService with a FakeFileReader (mocked IFileReader) injected
        var _videoService = new VideoService(_fileReader.Object);
    }


    [Test]
    public void ReadVideoTitle_EmptyFile_ReturnError()
    {
       

        // Setting up the mock to return an empty string when Read method is called with "video.txt" as the argument
        _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

       

        // Calling the ReadVideoTitle method on VideoService
        var result = _videoService.ReadVideoTitle();

        // Asserting that the result contains the substring "error" in a case-insensitive manner
        Assert.That(result, Does.Contain("error").IgnoreCase);
    }
}
