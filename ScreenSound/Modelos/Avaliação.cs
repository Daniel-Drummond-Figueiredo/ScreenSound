namespace ScreenSound.Modelos; 

internal class Avaliação
{
    public Avaliação(int nota)
    {
        Nota = nota;
    }
    public int Nota { get; }

    public static Avaliação Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliação(nota);
    }
}
