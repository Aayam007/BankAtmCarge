using BankCharge.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BankCharge.Service
{
    public class BankService : IBankService
    {
        private readonly IConfiguration configuration;


        public BankService(IConfiguration config)
        {
            this.configuration = config;
        }

        public IEnumerable<Bank> GetBanks()
        {
            List<Bank> bankList = new List<Bank>();

            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                bankList = con.Query<Bank>("GetBanks").ToList();
            }

            return bankList;
        }
        public IEnumerable<Bank> GetBankSearch(string search)
        {
            List<Bank> bankList = new List<Bank>();

            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                bankList = con.Query<Bank>("select * from BankCharge where Name like '" + search + "%'").ToList();
            }

            return bankList;
        }

        public Bank GetBankById(int? id)
        {
            Bank bank = new Bank();
            if (id == null)
                return bank;

            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                bank = con.Query<Bank>("GetBankByID", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }

            return bank;
        }

        public int New(Bank bank)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameters = new DynamicParameters();
                
                parameters.Add("@Name", bank.Name);
                parameters.Add("@Image", bank.Image);
                parameters.Add("@Charge", bank.Charge);
                parameters.Add("@CardType", bank.CardType);

                rowAffected = con.Execute("InsertBank", parameters, commandType: CommandType.StoredProcedure);
            }

            return rowAffected;
        }
        public int EditBank(Bank bank)
        {
            int rowAffected = 0;

            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BankId", bank.BankId);
                
                parameters.Add("@Name", bank.Name);
                parameters.Add("@Image", bank.Image);
                parameters.Add("@Charge", bank.Charge);
                parameters.Add("@CardType", bank.CardType);

                rowAffected = con.Execute("UpdateBank", parameters, commandType: CommandType.StoredProcedure);
            }
            return rowAffected;
        }
        public int DeleteBank(int id)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                rowAffected = con.Execute("DeleteBank", parameters, commandType: CommandType.StoredProcedure);

            }
            return rowAffected;
        }

      
    }
}
