namespace MVFC.Connectors.Financas.Bcb.Modelos.Response;

public sealed record BcbConglomeradoResponse(
        IReadOnlyList<BcbConglomeradoDto> Content,
        int TotalPages,
        int TotalElements,
        bool Last,
        int Number,
        int Size,
        int NumberOfElements,
        object Sort,
        bool First) : 
          BcbInstitucaoBaseDto<BcbConglomeradoDto>(
              Content, 
              TotalPages,
              TotalElements,
              Last,
              Number,
              Size,
              NumberOfElements,
              Sort,
              First);