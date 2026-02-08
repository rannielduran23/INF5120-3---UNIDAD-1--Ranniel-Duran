using System;

namespace INF512_Unidad1_POO
{
    public class CuentaBancaria
    {
        private string titular;
        private decimal saldo;

        public CuentaBancaria(string titular, decimal saldoInicial)
        {
            this.titular = titular;
            this.saldo = saldoInicial >= 0 ? saldoInicial : 0;
        }

        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo += monto;
            }
        }

        public bool Retirar(decimal monto)
        {
            if (monto > 0 && monto <= saldo)
            {
                saldo -= monto;
                return true;
            }
            return false;
        }

        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }
}
