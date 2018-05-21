#language: pt-BR

Funcionalidade: CadastroPessoa
	
Cenário: Pessoa não informa nome completo
	Dado que acesso o cadastro de pessoas
	Quando não informo nome completo
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Campo obrigatório" abaixo do campo nome completo

Cenário: Pessoa não informa CPF
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E não informo CPF
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Campo obrigatório" abaixo do campo CPF

Cenário: Pessoa não informa CEP
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E não informo CEP
	E informo endereço "Rua Dona Elisa Fláquer"
	E informo cidade "Santo André"
	E informo bairro "Centro"
	E informo estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Campo obrigatório" abaixo do campo CEP

Cenário: Pessoa não informa endereço
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E limpo o campo endereço
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Campo obrigatório" abaixo do campo endereço

Cenário: Pessoa não informa cidade
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E limpo o campo cidade
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Campo obrigatório" abaixo do campo cidade

Cenário: Pessoa não informa bairro
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E limpo o campo bairro
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Campo obrigatório" abaixo do campo bairro

Cenário: Pessoa não informa estado
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E limpo o campo estado
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Campo obrigatório" abaixo do campo estado

Cenário: Pessoa não informa número
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E não informo número
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Campo obrigatório" abaixo do campo número

Cenário: Pessoa não informa sexo
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E não informo sexo
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Selecione uma opção" abaixo do campo sexo

Cenário: Pessoa não informa tipo da necessidade
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo sim para necessidades especiais
	E não informo tipo da necessidade
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Selecione uma opção" abaixo do campo tipo da necessidade

Cenário: Pessoa informa letras no campo CPF
	Dado que acesso o cadastro de pessoas
	Quando informo CPF "abc"
	E tiro o foco do campo
	Então é exibida a mensagem "CPF incompleto" abaixo do campo CPF
	E o campo CPF deve conter ""

Cenário: Pessoa informa letras no campo CEP
	Dado que acesso o cadastro de pessoas
	Quando informo CEP "abc"
	E tiro o foco do campo
	Então é exibida a mensagem "CEP incompleto" abaixo do campo CEP
	E o campo CEP deve conter ""

Cenário: Pessoa informa letras no campo telefone
	Dado que acesso o cadastro de pessoas
	Quando informo telefone "abc"
	E tiro o foco do campo
	Então o campo telefone deve conter ""

Cenário: Pessoa informa que possui necessidades especiais
	Dado que acesso o cadastro de pessoas
	Quando informo sim para necessidades especiais
	Então deve ser exibido o campo tipo da necessidade

Cenário: Pessoa informa que não possui necessidades especiais
	Dado que acesso o cadastro de pessoas
	E informo sim para necessidades especiais
	E deve ser exibido o campo tipo da necessidade
	Quando informo não para necessidades especiais
	Então não deve ser exibido o campo tipo da necessidade

Cenário: Pessoa informa dados válidos
	Dado que acesso o cadastro de pessoas
	Quando informo nome completo "Rogério Silva"
	E informo CPF "56772009800"
	E informo CEP "09020160"
	E aguardo carregar o endereco "Rua Dona Elisa Fláquer"
	E aguardo carregar a cidade "Santo André"
	E aguardo carregar o bairro "Centro"
	E aguardo carregar o estado "SP"
	E informo número "70"
	E informo complemento "14º andar"
	E informo e-mail "rogerio.silva@gmail.com"
	E informo sexo masculino
	E informo não para necessidades especiais
	E informo telefone "1134586222"
	E informo celular "11989584238"
	E informo observações "teste"
	E pressiono o botão cadastrar
	Então é exibida a mensagem "Seu cadastro foi concluído com sucesso"
