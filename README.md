# MVFC.Connectors

Repositório de conectores MVFC para integração com diversos serviços públicos, financeiros, jurídicos, geográficos e de inteligência artificial. Cada conector é modularizado em seu próprio projeto, facilitando a manutenção, evolução e reutilização.

## Projetos

- [MVFC.Connectors.BrasilApi](src/MVFC.Connectors.BrasilApi) — Conectores para a [BrasilAPI](https://brasilapi.com.br/), permitindo acesso a bancos, CEPs, CNPJs, clima, feriados, FIPE, IBGE, ISBN, entre outros dados públicos nacionais.
- [MVFC.Connectors.Commons](src/MVFC.Connectors.Commons) — Componentes, utilitários e modelos comuns compartilhados entre os conectores, promovendo padronização e reutilização de código.
- [MVFC.Connectors.Conversores](src/MVFC.Connectors.Conversores) — Conversores para transformação de dados entre diferentes formatos e domínios, facilitando a interoperabilidade entre APIs e conectores.
- [MVFC.Connectors.Developer](src/MVFC.Connectors.Developer) — Utilitários e conectores para desenvolvedores, com ferramentas para integração, testes e depuração.
- [MVFC.Connectors.Financas](src/MVFC.Connectors.Financas) — Conectores para serviços financeiros, incluindo integração com APIs de bancos, câmbio, cotação de moedas, informações bancárias e financeiras.
- [MVFC.Connectors.Geo](src/MVFC.Connectors.Geo) — Conectores para serviços de geolocalização, consulta de coordenadas, cidades, estados e outras informações geográficas.
- [MVFC.Connectors.IA](src/MVFC.Connectors.IA) — Conectores para integração com serviços de Inteligência Artificial e machine learning, facilitando o acesso a APIs de IA.
- [MVFC.Connectors.Justica](src/MVFC.Connectors.Justica) — Conectores para serviços do sistema judiciário, permitindo consulta de informações jurídicas e integração com APIs do judiciário.

## Como utilizar

Cada projeto pode ser utilizado de forma independente, bastando referenciar o conector desejado em sua solução .NET. Consulte o README de cada pasta para detalhes de uso e exemplos.

## Estrutura

- `src/` — Código-fonte dos conectores
- `tests/` — Testes automatizados
- `CoverageReport/` — Relatórios de cobertura de testes

---

Para dúvidas, sugestões ou contribuições, abra uma issue ou envie um pull request.
