# Correios.Net
Status: Concluído.


A Correios.NET é uma biblioteca desenvolvida buscando fornecer ao desenvolvedor uma fácil integração das funcionalidades disponibilizadas no site dos correios ao seu sistema, de modo que fique tudo centralizado em um único sistema, melhorando, é claro, a experiência do usuário que vier a fazer o uso do mesmo.

Um dos pontos que levou ao desenvolvimento dessa biblioteca foi o fato de não termos confiança em APIs referentes a endereços disponibilizadas por terceiros, ou então contar com bancos de dados estáticos os quais nunca sabemos em que momento irão ficar obsoletos, sem contar que com o Correios.NET esses bancos de dados de endereços muitas vezes usados serão tornados obsoletos, para um entendimento mais claro de como irá funcionar acompanhe a descrição da biblioteca abaixo.

## Classes
* [`Correios.Net.BuscaCep`](https://github.com/volkoinen/Correios.Net/blob/1.0/src/BuscaCep.cs)
* [`Correios.Net.Address`](https://github.com/volkoinen/Correios.Net/blob/1.0/src/Address.cs)
* [`Correios.Net.Http.Request`](https://github.com/volkoinen/Correios.Net/blob/1.0/src/Http/Request.cs)
* [`Correios.Net.Http.Response`](https://github.com/volkoinen/Correios.Net/blob/1.0/src/Http/Response.cs)
* [`Correios.Net.Exceptions.InvalidArgumentException`](https://github.com/volkoinen/Correios.Net/blob/1.0/src/Exceptions/InvalidArgumentException.cs)


## Exemplo

Veja abaixo um simple exemplo aonde obtemos o endereço do cep 87710-130 chamando o método estático GetAddress da classe BuscaCep.
Esse endereço é retornado como um objeto Address, para facilitar o uso das informações.

```c#
public void buscaCep(string cep)
{
   Address address = BuscaCep.GetAddress(cep);
   
   labelStreet.Text   = address.Street     // Avenida Euclides da Cunha
   labelDistrict.Text = address.District;  // Jardim São Jorge
   labelCity.Text     = address.City;      // Paranavaí
   labelState.Text    = address.State;     // PR
   labelCep.Text      = address.Cep;       // 87710130
}
```

Não tem problema para estar requisitando CEPs que são os mesmos para a cidade toda. Neste caso o caso Street e Distric irão retornar
o valor `String.Empty` além `address.CepUnico` estar definido como `true`.

Veja o exemplo abaixo:
![Exemplo](http://s21.postimg.org/ok60b07dj/example.png)
![Exemplo](http://s10.postimg.org/v6qvsgs4p/example.png)
