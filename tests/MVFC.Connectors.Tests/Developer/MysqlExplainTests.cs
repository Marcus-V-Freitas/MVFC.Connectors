namespace MVFC.Connectors.Tests.Developer;

public sealed class MysqlExplainTests
{
    public static TheoryData<IMysqlExplainApi> Apis =>
     [
          MysqlExplainExtensoes.ObterMysqlExplainApi(),
          TestsHelpers.ObterApi<IMysqlExplainApi>(s => s.AddMysqlExplain()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterExplain_DeveRetornarItemAsync(IMysqlExplainApi api)
    {
        // Arrange
        var requestUrl = new MysqlExplainRequestUrl(
            Query: "SELECT * FROM actor WHERE first_name = ?",
            Bindings: ["PENELOPE"],
            Version: "8.0.32",
            ExplainJson: "{\"query_block\":{\"select_id\":1,\"cost_info\":{\"query_cost\":\"20.25\"},\"table\":{\"table_name\":\"actor\",\"access_type\":\"ALL\",\"rows_examined_per_scan\":200,\"rows_produced_per_join\":20,\"filtered\":\"10.00\",\"cost_info\":{\"read_cost\":\"18.25\",\"eval_cost\":\"2.00\",\"prefix_cost\":\"20.25\",\"data_read_per_join\":\"7K\"},\"used_columns\":[\"actor_id\",\"first_name\",\"last_name\",\"last_update\"],\"attached_condition\":\"(`sakila`.`actor`.`first_name` = 'PENELOPE')\"}}}",
            ExplainTree: "-> Filter: (actor.first_name = \\'PENELOPE\\')  (cost=20.2 rows=20)\n    -> Table scan on actor  (cost=20.2 rows=200)");

        // Act
        var visualExplainUrl = await api.ObterVisualExplainUrlAsync(requestUrl);

        // Assert
        visualExplainUrl.IsSuccessful.Should().BeTrue();
        visualExplainUrl.Content.Should().NotBeNull();

        // Act
        var visualExplainIframe = await api.ObterVisualExplainIFrameAsync(visualExplainUrl.Content!.Url);

        // Assert
        visualExplainIframe.IsSuccessful.Should().BeTrue();
        visualExplainIframe.Content.Should().NotBeNull();
    }
}