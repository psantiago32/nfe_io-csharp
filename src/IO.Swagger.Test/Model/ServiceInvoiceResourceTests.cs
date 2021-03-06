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
    ///  Class for testing ServiceInvoiceResource
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ServiceInvoiceResourceTests
    {
        // TODO uncomment below to declare an instance variable for ServiceInvoiceResource
        //private ServiceInvoiceResource instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ServiceInvoiceResource
            //instance = new ServiceInvoiceResource();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServiceInvoiceResource
        /// </summary>
        [Test]
        public void ServiceInvoiceResourceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ServiceInvoiceResource
            //Assert.IsInstanceOfType<ServiceInvoiceResource> (instance, "variable 'instance' is a ServiceInvoiceResource");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Environment'
        /// </summary>
        [Test]
        public void EnvironmentTest()
        {
            // TODO unit test for the property 'Environment'
        }
        /// <summary>
        /// Test the property 'FlowStatus'
        /// </summary>
        [Test]
        public void FlowStatusTest()
        {
            // TODO unit test for the property 'FlowStatus'
        }
        /// <summary>
        /// Test the property 'FlowMessage'
        /// </summary>
        [Test]
        public void FlowMessageTest()
        {
            // TODO unit test for the property 'FlowMessage'
        }
        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Test]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
        }
        /// <summary>
        /// Test the property 'Borrower'
        /// </summary>
        [Test]
        public void BorrowerTest()
        {
            // TODO unit test for the property 'Borrower'
        }
        /// <summary>
        /// Test the property 'BatchNumber'
        /// </summary>
        [Test]
        public void BatchNumberTest()
        {
            // TODO unit test for the property 'BatchNumber'
        }
        /// <summary>
        /// Test the property 'BatchCheckNumber'
        /// </summary>
        [Test]
        public void BatchCheckNumberTest()
        {
            // TODO unit test for the property 'BatchCheckNumber'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'CheckCode'
        /// </summary>
        [Test]
        public void CheckCodeTest()
        {
            // TODO unit test for the property 'CheckCode'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'RpsType'
        /// </summary>
        [Test]
        public void RpsTypeTest()
        {
            // TODO unit test for the property 'RpsType'
        }
        /// <summary>
        /// Test the property 'RpsStatus'
        /// </summary>
        [Test]
        public void RpsStatusTest()
        {
            // TODO unit test for the property 'RpsStatus'
        }
        /// <summary>
        /// Test the property 'TaxationType'
        /// </summary>
        [Test]
        public void TaxationTypeTest()
        {
            // TODO unit test for the property 'TaxationType'
        }
        /// <summary>
        /// Test the property 'IssuedOn'
        /// </summary>
        [Test]
        public void IssuedOnTest()
        {
            // TODO unit test for the property 'IssuedOn'
        }
        /// <summary>
        /// Test the property 'CancelledOn'
        /// </summary>
        [Test]
        public void CancelledOnTest()
        {
            // TODO unit test for the property 'CancelledOn'
        }
        /// <summary>
        /// Test the property 'RpsSerialNumber'
        /// </summary>
        [Test]
        public void RpsSerialNumberTest()
        {
            // TODO unit test for the property 'RpsSerialNumber'
        }
        /// <summary>
        /// Test the property 'RpsNumber'
        /// </summary>
        [Test]
        public void RpsNumberTest()
        {
            // TODO unit test for the property 'RpsNumber'
        }
        /// <summary>
        /// Test the property 'CityServiceCode'
        /// </summary>
        [Test]
        public void CityServiceCodeTest()
        {
            // TODO unit test for the property 'CityServiceCode'
        }
        /// <summary>
        /// Test the property 'FederalServiceCode'
        /// </summary>
        [Test]
        public void FederalServiceCodeTest()
        {
            // TODO unit test for the property 'FederalServiceCode'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'ServicesAmount'
        /// </summary>
        [Test]
        public void ServicesAmountTest()
        {
            // TODO unit test for the property 'ServicesAmount'
        }
        /// <summary>
        /// Test the property 'DeductionsAmount'
        /// </summary>
        [Test]
        public void DeductionsAmountTest()
        {
            // TODO unit test for the property 'DeductionsAmount'
        }
        /// <summary>
        /// Test the property 'DiscountUnconditionedAmount'
        /// </summary>
        [Test]
        public void DiscountUnconditionedAmountTest()
        {
            // TODO unit test for the property 'DiscountUnconditionedAmount'
        }
        /// <summary>
        /// Test the property 'DiscountConditionedAmount'
        /// </summary>
        [Test]
        public void DiscountConditionedAmountTest()
        {
            // TODO unit test for the property 'DiscountConditionedAmount'
        }
        /// <summary>
        /// Test the property 'BaseTaxAmount'
        /// </summary>
        [Test]
        public void BaseTaxAmountTest()
        {
            // TODO unit test for the property 'BaseTaxAmount'
        }
        /// <summary>
        /// Test the property 'IssRate'
        /// </summary>
        [Test]
        public void IssRateTest()
        {
            // TODO unit test for the property 'IssRate'
        }
        /// <summary>
        /// Test the property 'IssTaxAmount'
        /// </summary>
        [Test]
        public void IssTaxAmountTest()
        {
            // TODO unit test for the property 'IssTaxAmount'
        }
        /// <summary>
        /// Test the property 'IrAmountWithheld'
        /// </summary>
        [Test]
        public void IrAmountWithheldTest()
        {
            // TODO unit test for the property 'IrAmountWithheld'
        }
        /// <summary>
        /// Test the property 'PisAmountWithheld'
        /// </summary>
        [Test]
        public void PisAmountWithheldTest()
        {
            // TODO unit test for the property 'PisAmountWithheld'
        }
        /// <summary>
        /// Test the property 'CofinsAmountWithheld'
        /// </summary>
        [Test]
        public void CofinsAmountWithheldTest()
        {
            // TODO unit test for the property 'CofinsAmountWithheld'
        }
        /// <summary>
        /// Test the property 'CsllAmountWithheld'
        /// </summary>
        [Test]
        public void CsllAmountWithheldTest()
        {
            // TODO unit test for the property 'CsllAmountWithheld'
        }
        /// <summary>
        /// Test the property 'InssAmountWithheld'
        /// </summary>
        [Test]
        public void InssAmountWithheldTest()
        {
            // TODO unit test for the property 'InssAmountWithheld'
        }
        /// <summary>
        /// Test the property 'IssAmountWithheld'
        /// </summary>
        [Test]
        public void IssAmountWithheldTest()
        {
            // TODO unit test for the property 'IssAmountWithheld'
        }
        /// <summary>
        /// Test the property 'OthersAmountWithheld'
        /// </summary>
        [Test]
        public void OthersAmountWithheldTest()
        {
            // TODO unit test for the property 'OthersAmountWithheld'
        }
        /// <summary>
        /// Test the property 'AmountWithheld'
        /// </summary>
        [Test]
        public void AmountWithheldTest()
        {
            // TODO unit test for the property 'AmountWithheld'
        }
        /// <summary>
        /// Test the property 'AmountNet'
        /// </summary>
        [Test]
        public void AmountNetTest()
        {
            // TODO unit test for the property 'AmountNet'
        }
        /// <summary>
        /// Test the property 'ApproximateTax'
        /// </summary>
        [Test]
        public void ApproximateTaxTest()
        {
            // TODO unit test for the property 'ApproximateTax'
        }
        /// <summary>
        /// Test the property 'CreatedOn'
        /// </summary>
        [Test]
        public void CreatedOnTest()
        {
            // TODO unit test for the property 'CreatedOn'
        }
        /// <summary>
        /// Test the property 'ModifiedOn'
        /// </summary>
        [Test]
        public void ModifiedOnTest()
        {
            // TODO unit test for the property 'ModifiedOn'
        }

    }

}
