/* 
 * Service Invoice API (api.nfe.io)
 *
 * Seja bem-vindo a documentação do NFe.io!    Nossa API foi criada utilizando o padrão REST que possibilita a integração de seu sistema ao nosso, sendo assim você também pode extender ou   recriar as funcionalidades existentes na nossa plataforma, tudo isso consumindo a API que está documentada abaixo.    ### Como usar a documentação?  Logo a seguir você encontrará todos os recursos e metódos suportados pela API, sendo que essa página possibilita que você teste os recursos e métodos dirementamente através dela.     ### Como funciona a autenticação?  Você precisa de uma **chave de API (API Key)** para identificar a conta que está realizando solicitações para a API. Para isso você deve colocar sua chave de API no campo que se encontra topo desta página para que os métodos funcionem corretamente.  No seu código e integração temos suporte para autenticação de diversas formas sendo eles: **HTTP Header (Authorization ou X-NFEIO-APIKEY)** ou **HTTP Query String (api_key)** nos dois modos passando o valor da sua chave de api (API Key).  
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DateRange
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DateRangeTests
    {
        // TODO uncomment below to declare an instance variable for DateRange
        //private DateRange instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DateRange
            //instance = new DateRange();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DateRange
        /// </summary>
        [Test]
        public void DateRangeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DateRange
            //Assert.IsInstanceOfType<DateRange> (instance, "variable 'instance' is a DateRange");
        }

        /// <summary>
        /// Test the property 'Begin'
        /// </summary>
        [Test]
        public void BeginTest()
        {
            // TODO unit test for the property 'Begin'
        }
        /// <summary>
        /// Test the property 'End'
        /// </summary>
        [Test]
        public void EndTest()
        {
            // TODO unit test for the property 'End'
        }

    }

}
