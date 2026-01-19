namespace MVFC.Connectors.Financas.Bcb.Modelos.Response;

public sealed record BcbAgenciaResponse(
        IReadOnlyList<BcbAgenciaDto> Content,
        int TotalPages,
        int TotalElements,
        bool Last,
        int Number,
        int Size,
        int NumberOfElements,
        object Sort,
        bool First) :
          BcbInstitucaoBaseDto<BcbAgenciaDto>(
              Content,
              TotalPages,
              TotalElements,
              Last,
              Number,
              Size,
              NumberOfElements,
              Sort,
              First);