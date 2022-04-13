namespace _07_ByteBank
{
    public class cliente
    {
        private string _cpf;

        public string Nome { get; set; }

        public string Cpf {
            get
            {
                return _cpf;    
            }

            set { _cpf = value; }

    }
}