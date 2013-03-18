# Correios.Net

A Correios.NET é uma biblioteca desenvolvida buscando fornecer ao desenvolvedor uma fácil integração das funcionalidades disponibilizadas no site dos correios ao seu site, de modo que fique tudo centralizado em um único sistema, melhorando, é claro, a experiência do usuário que vier a fazer o uso do mesmo.

Um dos pontos que levou ao desenvolvimento dessa biblioteca foi o fato de não termos confiança em APIs referentes a endereços disponibilizadas por terceiros, ou então contar com bancos de dados estáticos os quais nunca sabemos em que momento irão ficar obsoletos, sem contar que com o Correios.NET esses bancos de dados de endereços muitas vezes usados serão tornados obsoletos, para um entendimento mais claro de como irá funcionar acompanhe a descrição da biblioteca abaixo.

## Classes
* [`Correios.Net.BuscaCep`](https://github.com/volkoinen/Correios.Net/wiki/Correios.Net.BuscaCep)


## Exemplo

```c#

public void buscaCep(int cep)
{
   Correios.Net.Address Address = Correios.Net.Buscacep("87710-130").GetAddress();
   
   labelStreet.Text = Address.Street;
   labelCity.Text   = Address.City;
   labelState.Text  = Address.State;
}

```
