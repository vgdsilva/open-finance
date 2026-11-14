# Sistema de Gestão Financeira

### 1. Necessidade

Eu preciso de um sistema onde eu posso ter uma visão geral de toda a minha carteira de um modo operacional (sendo esse modo operacional a parte de CRUDS dentro do sistem) e um modo de linguagem natural (sendo ele um chat usando IA ou algo mais simples) para que eu possa escrever em uma linguagem natural o que eu preciso saber sobre meu contexto financeiro.

### 2. Como é hoje

1. No fim do mes eu pego um notebook, pego meu holerite do mes passado e vejo +- o que eu vou ter de receita. Ai pego o que vou ter de despesas como meu cartão de credito, faço a subtração e vou para ver o que sobra.
2. Com o que sobra eu divido em investimentos (Compra do apartamento e Reserva de emergencia) vejo o quanto pretendo guardar em cada e subtraio.
3. Com o restante eu vejo minhas despesas, luz, internet, abasteceter o carro que passo no debito, condominio e assim vai
4. com isso eu tenho o que me resta para o mes

### 3. O que eu quero construir

Um sistema web de controle, onde segue com o fluxo do que trabalho hoje, um CRM/ERP, que vou ter um usuario adm que vai ser para acessar a parte administrativa do sistema como usuarios, sessões, configurações globais que afetam todos, logs de auditoria, consulta em banco de dados, envios de e-mail e outras coisas.
Teremos tambem o usuario comum, que vai ter a acesso a sua visão de "carteira", como se ele estivesse abrindo a carteira dele e tendo a visão de tudo, com as contas bancarias, os cartões de credito com suas transações e fatura, os gastos variaveis, fixos e ja pagos e não pagos.
#### 3.1 Modulos que fazem sentido no sistema
- Administração
    - Usuarios
    - Logs de auditoria
    - Sessões ativas
    - Configurações
    - Email
- Comum
  - Contas Bancarias
      - Cartões de credito
        - Fatura
      - Valor na conta (previstoXreal)
  - Gastos
    - Fixos
    - Variados
    - Pagos
    - Não pagos
