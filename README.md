# Correios.Net
Status: [Em Desenvolvimento](http://www.youtube.com/watch?v=WuhOSr7xzCY)


A Correios.NET é uma biblioteca desenvolvida buscando fornecer ao desenvolvedor uma fácil integração das funcionalidades disponibilizadas no site dos correios ao seu sistema, de modo que fique tudo centralizado em um único sistema, melhorando, é claro, a experiência do usuário que vier a fazer o uso do mesmo.

Um dos pontos que levou ao desenvolvimento dessa biblioteca foi o fato de não termos confiança em APIs referentes a endereços disponibilizadas por terceiros, ou então contar com bancos de dados estáticos os quais nunca sabemos em que momento irão ficar obsoletos, sem contar que com o Correios.NET esses bancos de dados de endereços muitas vezes usados serão tornados obsoletos, para um entendimento mais claro de como irá funcionar acompanhe a descrição da biblioteca abaixo.

## Classes
* [`Correios.Net.BuscaCep`](https://github.com/volkoinen/Correios.Net/wiki/Correios.Net.BuscaCep)
* [`Correios.Net.Address`](https://github.com/volkoinen/Correios.Net/wiki/Correios.Net.BuscaCep)
* [`Correios.Net.Exceptions.InvalidArgumentException`](https://github.com/volkoinen/Correios.Net/wiki/Correios.Net.BuscaCep)


## Exemplo

Veja abaixo um simple exemplo aonde obtemos o endereço do cep 87710-000 chamando o método estático GetAddress da classe BuscaCep.
Esse endereço é retornado como um objeto Address, para facilitar o uso das informações.

```c#

public void buscaCep(int cep)
{
   Correios.Net.Address Address = Correios.Net.BuscaCep.GetAddress("87710-000");
   
   labelStreet.Text = Address.Street;
   labelCity.Text   = Address.City;
   labelState.Text  = Address.State;
}

```
