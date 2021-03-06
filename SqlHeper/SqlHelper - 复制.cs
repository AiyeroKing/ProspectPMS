﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHeper
{
    public class SqlHelper
    {
        /// <summary>
        /// 获取web.config的连接字符串
        /// </summary>
        private static readonly string connstr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        #region--连接数据库 

        public SqlConnection Conn()
        {
            SqlConnection myConn = new SqlConnection(connstr);
            return myConn;
        }

        #endregion

        #region--连接SqlConnection,执行SQL 功能:增加、删除、更新--  
        public void ExecData(string sqlstr, SqlParameter[] para)
        {
            SqlConnection sqlcon = this.Conn();
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sqlstr, sqlcon);

            foreach (var item in para)
            {
                sqlcom.Parameters.Add(item);
            }

            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            sqlcon.Close();
            sqlcon.Dispose();
        }

        #endregion

        #region--创建SqlDataReader对象  功能:查询--  
        public SqlDataReader ReadData(string sqlstr, SqlParameter[] para)
        {
            SqlConnection sqlcon = this.Conn();
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sqlstr, sqlcon);
            foreach (var item in para)
            {
                sqlcom.Parameters.Add(item);
            }
            SqlDataReader sqlread = sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return sqlread;
        }

        #endregion
        
        #region--从数据库中读取到的DataTable表
        /// <summary>
        /// 将数据加载到本地，在本地对数据进行操作
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameter">参数化查询</param>
        /// <returns>返回从数据库中读取到的DataTable表</returns>
        /// 
        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameter)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameter);
                DataTable tab = new DataTable();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    tab.Load(reader);
                    return tab;

                }
            }
        }

        #endregion

        #region --用于执行增加和删除语句
        /// <summary>
        /// 用于执行增加和删除语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameter">参数化查询</param>
        /// <returns>有多少语句执行成功</returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameter)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameter);
                return cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region --执行语句后，返回第一行第一列的数据
        /// <summary>
        /// 执行语句后，返回第一行第一列的数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns>object类型的值</returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] parameter)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameter);
                return cmd.ExecuteScalar();
            }
        }
        #endregion

        #region --在数据库中，进行数据库的查询操作
        /// <summary>
        /// 在数据库中，进行数据库的查询操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameter)
        {
            SqlConnection conn = new SqlConnection(connstr);
            using (SqlCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameter);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
        #endregion

    }
}
