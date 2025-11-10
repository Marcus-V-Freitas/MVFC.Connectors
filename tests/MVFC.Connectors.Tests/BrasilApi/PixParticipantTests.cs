////namespace MVFC.Connectors.Tests.BrasilApi;

////public sealed class PixParticipantTests
////{
////    private readonly IPixParticipantBrasilApi _brasilApiConsole = PixParticipantBrasilApiExtensoes.ObterPixParticipantBrasilApi();
////    private readonly IPixParticipantBrasilApi _brasilApiDI = TestsHelpers.ObterApi<IPixParticipantBrasilApi>(s => s.AddPixParticipantBrasilApi());

////    [Fact]
////    public async Task RecuperarPixParticipants_Console_DeveRetornarItem()
////    {
////        // Arrange & Act
////        var pixParticipants = await _brasilApiConsole.GetPixParticipantsAsync();

////        // Assert
////        pixParticipants.IsSuccessful.Should().BeTrue();
////        pixParticipants.Content.Should().NotBeNull();
////    }

////    [Fact]
////    public async Task RecuperarPixParticipants_DI_DeveRetornarItem()
////    {
////        // Arrange & Act
////        var pixParticipants = await _brasilApiDI.GetPixParticipantsAsync();

////        // Assert
////        pixParticipants.IsSuccessful.Should().BeTrue();
////        pixParticipants.Content.Should().NotBeNull();
////    }
////}