Feature: Correios
Entro no site dos correios, busco por cep invalido, valido mensagem, volto pro inicio, 
testo um cep valido valido endereço e UF, depois volto ao inicio e busco no ratreamento um codigo
que com certeza valido ou não a consulta vai gerar erro porque a pagina tem um validor dinamico 
retornado mensagem Preencha o campo captcha.


@Mytag1
Scenario: Efetuar teste com CEP invalido.
	Given Eu abro o site dos Correios
	And No campo buscar CEP ou endereço preencho um valor invalido.
		|  endereco  |
		|  80700000  |
	When Eu pressiono o botão buscar, lupa ou dou enter.
	Then o resultado deve ser a mensagem "Dados não encontrado".

Scenario: Efetuar Teste com CEP Valido.
	Given Eu volto ao inicio da pagina
	And Eu no campo buscar CEP ou endereço preencho um valor valido
		|  endereco   |
		|  01013-001  |
	When Eu pressiono o botão lupa ou pressiono enter
	Then o resultado deve conter "Rua Quinze de Novembro" e "São Paulo/SP"

Scenario: Efetuar rastreio 
	Given Eu volto a pagina inicial
	And No campo ratreio clico no lupa ou pressione enter
	And Na pagina de rastreio preencho o valor
	  |  rastreio       |
	  |  SS987654321BR  |
Then o resultado deve ser a mensagem "Digite o texto contido na imagem".
