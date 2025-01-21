namespace tabuleiro
{
    class Tabuleiro
    {
        public int linha { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int colunas, int linhas)
        {
            this.colunas = colunas;
            this.linha = linhas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
