namespace MVFC.Connectors.Tests.Developer;

public sealed class DaliboExplainTests : ConnectorTestsBase<IDaliboExplainApi>
{
    protected override IDaliboExplainApi ManualApi => DaliboExtensoesExplain.ObterDaliboExplainApi();

    protected override IDaliboExplainApi ServiceCollectionApi => TestsHelpers.ObterApi<IDaliboExplainApi>(s => s.AddDaliboExplain());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IDaliboExplainApi api) =>
        api.GerarVisualExplainUrlAsync(CriarRequest());

    [Fact]
    public async Task ObterExplain_DeveRetornarItemAsync()
    {
        // Arrange
        var requestUrl = CriarRequest();
        // Act
        var visualExplainUrl = await ManualApi.GerarVisualExplainUrlAsync(requestUrl);

        // Assert
        visualExplainUrl.IsSuccessful.Should().BeTrue();
        visualExplainUrl.Content.Should().NotBeNull();

        // Act
        var visualExplainHtml = await ManualApi.ObterVisualExplainIAsync(visualExplainUrl.Content!.Id);

        // Assert
        visualExplainHtml.IsSuccessful.Should().BeTrue();
        visualExplainHtml.Content.Should().NotBeNull();
    }

    private static DaliboExplainRequestUrl CriarRequest() =>
        new(
            Title: "Análise MERGE em tb",
            Plan: """
                  [
                    {
                      "Plan": {
                        "Node Type": "Nested Loop",
                        "Parallel Aware": false,
                        "Join Type": "Left",
                        "Startup Cost": 11.95,
                        "Total Cost": 28.52,
                        "Plan Rows": 5,
                        "Plan Width": 157,
                        "Actual Startup Time": 0.007,
                        "Actual Total Time": 0.007,
                        "Actual Rows": 0,
                        "Actual Loops": 1,
                        "Output": ["rel_users_exams.user_username", "rel_users_exams.exam_id", "rel_users_exams.started_at", "rel_users_exams.finished_at", "exam_1.id", "exam_1.title", "exam_1.date_from", "exam_1.date_to", "exam_1.created", "exam_1.created_by_", "exam_1.duration", "exam_1.success_threshold", "exam_1.published"],
                        "Inner Unique": true,
                        "Join Filter": "(exam_1.id = rel_users_exams.exam_id)",
                        "Rows Removed by Join Filter": 0,
                        "Shared Hit Blocks": 1,
                        "Shared Read Blocks": 0,
                        "Shared Dirtied Blocks": 0,
                        "Shared Written Blocks": 0,
                        "Local Hit Blocks": 0,
                        "Local Read Blocks": 0,
                        "Local Dirtied Blocks": 0,
                        "Local Written Blocks": 0,
                        "Temp Read Blocks": 0,
                        "Temp Written Blocks": 0,
                        "Plans": [
                          {
                            "Node Type": "Bitmap Heap Scan",
                            "Parent Relationship": "Outer",
                            "Parallel Aware": false,
                            "Relation Name": "rel_users_exams",
                            "Schema": "public",
                            "Alias": "rel_users_exams",
                            "Startup Cost": 11.80,
                            "Total Cost": 20.27,
                            "Plan Rows": 5,
                            "Plan Width": 52,
                            "Actual Startup Time": 0.006,
                            "Actual Total Time": 0.006,
                            "Actual Rows": 0,
                            "Actual Loops": 1,
                            "Output": ["rel_users_exams.user_username", "rel_users_exams.exam_id", "rel_users_exams.started_at", "rel_users_exams.finished_at"],
                            "Recheck Cond": "(1 = rel_users_exams.exam_id)",
                            "Rows Removed by Index Recheck": 0,
                            "Exact Heap Blocks": 0,
                            "Lossy Heap Blocks": 0,
                            "Shared Hit Blocks": 1,
                            "Shared Read Blocks": 0,
                            "Shared Dirtied Blocks": 0,
                            "Shared Written Blocks": 0,
                            "Local Hit Blocks": 0,
                            "Local Read Blocks": 0,
                            "Local Dirtied Blocks": 0,
                            "Local Written Blocks": 0,
                            "Temp Read Blocks": 0,
                            "Temp Written Blocks": 0,
                            "Plans": [
                              {
                                "Node Type": "Bitmap Index Scan",
                                "Parent Relationship": "Outer",
                                "Parallel Aware": false,
                                "Index Name": "rel_users_exams_pkey",
                                "Startup Cost": 0.00,
                                "Total Cost": 11.80,
                                "Plan Rows": 5,
                                "Plan Width": 0,
                                "Actual Startup Time": 0.003,
                                "Actual Total Time": 0.004,
                                "Actual Rows": 0,
                                "Actual Loops": 1,
                                "Index Cond": "(1 = rel_users_exams.exam_id)",
                                "Shared Hit Blocks": 1,
                                "Shared Read Blocks": 0,
                                "Shared Dirtied Blocks": 0,
                                "Shared Written Blocks": 0,
                                "Local Hit Blocks": 0,
                                "Local Read Blocks": 0,
                                "Local Dirtied Blocks": 0,
                                "Local Written Blocks": 0,
                                "Temp Read Blocks": 0,
                                "Temp Written Blocks": 0
                              }
                            ]
                          },
                          {
                            "Node Type": "Materialize",
                            "Parent Relationship": "Inner",
                            "Parallel Aware": false,
                            "Startup Cost": 0.15,
                            "Total Cost": 8.17,
                            "Plan Rows": 1,
                            "Plan Width": 105,
                            "Actual Startup Time": 0.000,
                            "Actual Total Time": 0.000,
                            "Actual Rows": 0,
                            "Actual Loops": 0,
                            "Output": ["exam_1.id", "exam_1.title", "exam_1.date_from", "exam_1.date_to", "exam_1.created", "exam_1.created_by_", "exam_1.duration", "exam_1.success_threshold", "exam_1.published"],
                            "Shared Hit Blocks": 0,
                            "Shared Read Blocks": 0,
                            "Shared Dirtied Blocks": 0,
                            "Shared Written Blocks": 0,
                            "Local Hit Blocks": 0,
                            "Local Read Blocks": 0,
                            "Local Dirtied Blocks": 0,
                            "Local Written Blocks": 0,
                            "Temp Read Blocks": 0,
                            "Temp Written Blocks": 0,
                            "Plans": [
                              {
                                "Node Type": "Index Scan",
                                "Parent Relationship": "Outer",
                                "Parallel Aware": false,
                                "Scan Direction": "Forward",
                                "Index Name": "exam_pkey",
                                "Relation Name": "exam",
                                "Schema": "public",
                                "Alias": "exam_1",
                                "Startup Cost": 0.15,
                                "Total Cost": 8.17,
                                "Plan Rows": 1,
                                "Plan Width": 105,
                                "Actual Startup Time": 0.000,
                                "Actual Total Time": 0.000,
                                "Actual Rows": 0,
                                "Actual Loops": 0,
                                "Output": ["exam_1.id", "exam_1.title", "exam_1.date_from", "exam_1.date_to", "exam_1.created", "exam_1.created_by_", "exam_1.duration", "exam_1.success_threshold", "exam_1.published"],
                                "Index Cond": "(exam_1.id = 1)",
                                "Rows Removed by Index Recheck": 0,
                                "Shared Hit Blocks": 0,
                                "Shared Read Blocks": 0,
                                "Shared Dirtied Blocks": 0,
                                "Shared Written Blocks": 0,
                                "Local Hit Blocks": 0,
                                "Local Read Blocks": 0,
                                "Local Dirtied Blocks": 0,
                                "Local Written Blocks": 0,
                                "Temp Read Blocks": 0,
                                "Temp Written Blocks": 0
                              }
                            ]
                          }
                        ]
                      },
                      "Planning Time": 0.905,
                      "Triggers": [
                      ],
                      "Execution Time": 0.134
                    }
                  ]
                  """,
            Query: """
                   /* A join between two tables */
                   SELECT rel_users_exams.user_username AS rel_users_exams_user_username,
                            rel_users_exams.exam_id AS rel_users_exams_exam_id,
                            rel_users_exams.started_at AS rel_users_exams_started_at,
                            rel_users_exams.finished_at AS rel_users_exams_finished_at,
                            exam_1.id AS exam_1_id,
                            exam_1.title AS exam_1_title,
                            exam_1.date_from AS exam_1_date_from,
                            exam_1.date_to AS exam_1_date_to,
                            exam_1.created AS exam_1_created,
                            exam_1.created_by_ AS exam_1_created_by_,
                            exam_1.duration AS exam_1_duration,
                            exam_1.success_threshold AS exam_1_success_threshold,
                            exam_1.published AS exam_1_published
                   FROM rel_users_exams LEFT OUTER
                   JOIN exam AS exam_1
                       ON exam_1.id = rel_users_exams.exam_id
                   WHERE 1 = rel_users_exams.exam_id;                   
                   """);
}
