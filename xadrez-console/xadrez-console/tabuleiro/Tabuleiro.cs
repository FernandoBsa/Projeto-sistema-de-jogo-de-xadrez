namespace tabuleiro
{
    class Tabuleiro
    {
        public int linnha { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int colunas, int linhas)
        {
            this.colunas = colunas;
            this.linnha = linnha;
            pecas = new Peca[linhas, colunas];
        }
    }
}
