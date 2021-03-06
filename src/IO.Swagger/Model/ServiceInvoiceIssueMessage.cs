/* 
 * Service Invoice API (api.nfe.io)
 *
 * Seja bem-vindo a documentação do NFe.io!    Nossa API foi criada utilizando o padrão REST que possibilita a integração de seu sistema ao nosso, sendo assim você também pode extender ou   recriar as funcionalidades existentes na nossa plataforma, tudo isso consumindo a API que está documentada abaixo.    ### Como usar a documentação?  Logo a seguir você encontrará todos os recursos e metódos suportados pela API, sendo que essa página possibilita que você teste os recursos e métodos dirementamente através dela.     ### Como funciona a autenticação?  Você precisa de uma **chave de API (API Key)** para identificar a conta que está realizando solicitações para a API. Para isso você deve colocar sua chave de API no campo que se encontra topo desta página para que os métodos funcionem corretamente.  No seu código e integração temos suporte para autenticação de diversas formas sendo eles: **HTTP Header (Authorization ou X-NFEIO-APIKEY)** ou **HTTP Query String (api_key)** nos dois modos passando o valor da sua chave de api (API Key).  
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Emissão de nota fiscal de serviço
    /// </summary>
    [DataContract]
    public partial class ServiceInvoiceIssueMessage :  IEquatable<ServiceInvoiceIssueMessage>, IValidatableObject
    {
        /// <summary>
        /// Tipo da tributação
        /// </summary>
        /// <value>Tipo da tributação</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxationTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum WithinCity for "WithinCity"
            /// </summary>
            [EnumMember(Value = "WithinCity")]
            WithinCity,
            
            /// <summary>
            /// Enum OutsideCity for "OutsideCity"
            /// </summary>
            [EnumMember(Value = "OutsideCity")]
            OutsideCity,
            
            /// <summary>
            /// Enum Export for "Export"
            /// </summary>
            [EnumMember(Value = "Export")]
            Export,
            
            /// <summary>
            /// Enum Free for "Free"
            /// </summary>
            [EnumMember(Value = "Free")]
            Free,
            
            /// <summary>
            /// Enum Immune for "Immune"
            /// </summary>
            [EnumMember(Value = "Immune")]
            Immune,
            
            /// <summary>
            /// Enum SuspendedCourtDecision for "SuspendedCourtDecision"
            /// </summary>
            [EnumMember(Value = "SuspendedCourtDecision")]
            SuspendedCourtDecision,
            
            /// <summary>
            /// Enum SuspendedAdministrativeProcedure for "SuspendedAdministrativeProcedure"
            /// </summary>
            [EnumMember(Value = "SuspendedAdministrativeProcedure")]
            SuspendedAdministrativeProcedure,
            
            /// <summary>
            /// Enum OutsideCityFree for "OutsideCityFree"
            /// </summary>
            [EnumMember(Value = "OutsideCityFree")]
            OutsideCityFree,
            
            /// <summary>
            /// Enum OutsideCityImmune for "OutsideCityImmune"
            /// </summary>
            [EnumMember(Value = "OutsideCityImmune")]
            OutsideCityImmune,
            
            /// <summary>
            /// Enum OutsideCitySuspended for "OutsideCitySuspended"
            /// </summary>
            [EnumMember(Value = "OutsideCitySuspended")]
            OutsideCitySuspended,
            
            /// <summary>
            /// Enum OutsideCitySuspendedAdministrativeProcedure for "OutsideCitySuspendedAdministrativeProcedure"
            /// </summary>
            [EnumMember(Value = "OutsideCitySuspendedAdministrativeProcedure")]
            OutsideCitySuspendedAdministrativeProcedure
        }

        /// <summary>
        /// Tipo da tributação
        /// </summary>
        /// <value>Tipo da tributação</value>
        [DataMember(Name="taxationType", EmitDefaultValue=false)]
        public TaxationTypeEnum? TaxationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInvoiceIssueMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceInvoiceIssueMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInvoiceIssueMessage" /> class.
        /// </summary>
        /// <param name="Borrower">Tomador dos serviços (required).</param>
        /// <param name="CityServiceCode">Código do serviço no municipio (required).</param>
        /// <param name="FederalServiceCode">Código federal do servico (Item da lista de serviço LC 116).</param>
        /// <param name="CnaeCode">Código CNAE (somente quando necessario na cidade).</param>
        /// <param name="Description">Descrição dos serviços (required).</param>
        /// <param name="ServicesAmount">Valor do serviços (required).</param>
        /// <param name="RpsSerialNumber">Número de Serie da RPS.</param>
        /// <param name="IssuedOn">Data da emissão.</param>
        /// <param name="RpsNumber">Número da RPS.</param>
        /// <param name="TaxationType">Tipo da tributação.</param>
        /// <param name="IssRate">Aliquota do ISS.</param>
        /// <param name="IssTaxAmount">Valor do ISS.</param>
        /// <param name="DeductionsAmount">Valor de deduções.</param>
        /// <param name="DiscountUnconditionedAmount">Valor do desconto incondicionado.</param>
        /// <param name="DiscountConditionedAmount">Valor do desconto condicionado.</param>
        /// <param name="IrAmountWithheld">Valor retido do Imposto de Renda (IR).</param>
        /// <param name="PisAmountWithheld">Valor retido do PIS.</param>
        /// <param name="CofinsAmountWithheld">Valor retido do COFINS.</param>
        /// <param name="CsllAmountWithheld">Valor retido do CSLL.</param>
        /// <param name="InssAmountWithheld">Valor retido do INSS.</param>
        /// <param name="IssAmountWithheld">Valor retido do ISS.</param>
        /// <param name="OthersAmountWithheld">Valor de outras retenções.</param>
        /// <param name="ApproximateTax">Tributos aproximados.</param>
        public ServiceInvoiceIssueMessage(Borrower Borrower = default(Borrower), string CityServiceCode = default(string), string FederalServiceCode = default(string), string CnaeCode = default(string), string Description = default(string), double? ServicesAmount = default(double?), string RpsSerialNumber = default(string), DateTime? IssuedOn = default(DateTime?), long? RpsNumber = default(long?), TaxationTypeEnum? TaxationType = default(TaxationTypeEnum?), double? IssRate = default(double?), double? IssTaxAmount = default(double?), double? DeductionsAmount = default(double?), double? DiscountUnconditionedAmount = default(double?), double? DiscountConditionedAmount = default(double?), double? IrAmountWithheld = default(double?), double? PisAmountWithheld = default(double?), double? CofinsAmountWithheld = default(double?), double? CsllAmountWithheld = default(double?), double? InssAmountWithheld = default(double?), double? IssAmountWithheld = default(double?), double? OthersAmountWithheld = default(double?), ServiceInvoiceApproximateTaxesResource ApproximateTax = default(ServiceInvoiceApproximateTaxesResource))
        {
            // to ensure "Borrower" is required (not null)
            if (Borrower == null)
            {
                throw new InvalidDataException("Borrower is a required property for ServiceInvoiceIssueMessage and cannot be null");
            }
            else
            {
                this.Borrower = Borrower;
            }
            // to ensure "CityServiceCode" is required (not null)
            if (CityServiceCode == null)
            {
                throw new InvalidDataException("CityServiceCode is a required property for ServiceInvoiceIssueMessage and cannot be null");
            }
            else
            {
                this.CityServiceCode = CityServiceCode;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ServiceInvoiceIssueMessage and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "ServicesAmount" is required (not null)
            if (ServicesAmount == null)
            {
                throw new InvalidDataException("ServicesAmount is a required property for ServiceInvoiceIssueMessage and cannot be null");
            }
            else
            {
                this.ServicesAmount = ServicesAmount;
            }
            this.FederalServiceCode = FederalServiceCode;
            this.CnaeCode = CnaeCode;
            this.RpsSerialNumber = RpsSerialNumber;
            this.IssuedOn = IssuedOn;
            this.RpsNumber = RpsNumber;
            this.TaxationType = TaxationType;
            this.IssRate = IssRate;
            this.IssTaxAmount = IssTaxAmount;
            this.DeductionsAmount = DeductionsAmount;
            this.DiscountUnconditionedAmount = DiscountUnconditionedAmount;
            this.DiscountConditionedAmount = DiscountConditionedAmount;
            this.IrAmountWithheld = IrAmountWithheld;
            this.PisAmountWithheld = PisAmountWithheld;
            this.CofinsAmountWithheld = CofinsAmountWithheld;
            this.CsllAmountWithheld = CsllAmountWithheld;
            this.InssAmountWithheld = InssAmountWithheld;
            this.IssAmountWithheld = IssAmountWithheld;
            this.OthersAmountWithheld = OthersAmountWithheld;
            this.ApproximateTax = ApproximateTax;
        }
        
        /// <summary>
        /// Tomador dos serviços
        /// </summary>
        /// <value>Tomador dos serviços</value>
        [DataMember(Name="borrower", EmitDefaultValue=false)]
        public Borrower Borrower { get; set; }
        /// <summary>
        /// Código do serviço no municipio
        /// </summary>
        /// <value>Código do serviço no municipio</value>
        [DataMember(Name="cityServiceCode", EmitDefaultValue=false)]
        public string CityServiceCode { get; set; }
        /// <summary>
        /// Código federal do servico (Item da lista de serviço LC 116)
        /// </summary>
        /// <value>Código federal do servico (Item da lista de serviço LC 116)</value>
        [DataMember(Name="federalServiceCode", EmitDefaultValue=false)]
        public string FederalServiceCode { get; set; }
        /// <summary>
        /// Código CNAE (somente quando necessario na cidade)
        /// </summary>
        /// <value>Código CNAE (somente quando necessario na cidade)</value>
        [DataMember(Name="cnaeCode", EmitDefaultValue=false)]
        public string CnaeCode { get; set; }
        /// <summary>
        /// Descrição dos serviços
        /// </summary>
        /// <value>Descrição dos serviços</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Valor do serviços
        /// </summary>
        /// <value>Valor do serviços</value>
        [DataMember(Name="servicesAmount", EmitDefaultValue=false)]
        public double? ServicesAmount { get; set; }
        /// <summary>
        /// Número de Serie da RPS
        /// </summary>
        /// <value>Número de Serie da RPS</value>
        [DataMember(Name="rpsSerialNumber", EmitDefaultValue=false)]
        public string RpsSerialNumber { get; set; }
        /// <summary>
        /// Data da emissão
        /// </summary>
        /// <value>Data da emissão</value>
        [DataMember(Name="issuedOn", EmitDefaultValue=false)]
        public DateTime? IssuedOn { get; set; }
        /// <summary>
        /// Número da RPS
        /// </summary>
        /// <value>Número da RPS</value>
        [DataMember(Name="rpsNumber", EmitDefaultValue=false)]
        public long? RpsNumber { get; set; }
        /// <summary>
        /// Aliquota do ISS
        /// </summary>
        /// <value>Aliquota do ISS</value>
        [DataMember(Name="issRate", EmitDefaultValue=false)]
        public double? IssRate { get; set; }
        /// <summary>
        /// Valor do ISS
        /// </summary>
        /// <value>Valor do ISS</value>
        [DataMember(Name="issTaxAmount", EmitDefaultValue=false)]
        public double? IssTaxAmount { get; set; }
        /// <summary>
        /// Valor de deduções
        /// </summary>
        /// <value>Valor de deduções</value>
        [DataMember(Name="deductionsAmount", EmitDefaultValue=false)]
        public double? DeductionsAmount { get; set; }
        /// <summary>
        /// Valor do desconto incondicionado
        /// </summary>
        /// <value>Valor do desconto incondicionado</value>
        [DataMember(Name="discountUnconditionedAmount", EmitDefaultValue=false)]
        public double? DiscountUnconditionedAmount { get; set; }
        /// <summary>
        /// Valor do desconto condicionado
        /// </summary>
        /// <value>Valor do desconto condicionado</value>
        [DataMember(Name="discountConditionedAmount", EmitDefaultValue=false)]
        public double? DiscountConditionedAmount { get; set; }
        /// <summary>
        /// Valor retido do Imposto de Renda (IR)
        /// </summary>
        /// <value>Valor retido do Imposto de Renda (IR)</value>
        [DataMember(Name="irAmountWithheld", EmitDefaultValue=false)]
        public double? IrAmountWithheld { get; set; }
        /// <summary>
        /// Valor retido do PIS
        /// </summary>
        /// <value>Valor retido do PIS</value>
        [DataMember(Name="pisAmountWithheld", EmitDefaultValue=false)]
        public double? PisAmountWithheld { get; set; }
        /// <summary>
        /// Valor retido do COFINS
        /// </summary>
        /// <value>Valor retido do COFINS</value>
        [DataMember(Name="cofinsAmountWithheld", EmitDefaultValue=false)]
        public double? CofinsAmountWithheld { get; set; }
        /// <summary>
        /// Valor retido do CSLL
        /// </summary>
        /// <value>Valor retido do CSLL</value>
        [DataMember(Name="csllAmountWithheld", EmitDefaultValue=false)]
        public double? CsllAmountWithheld { get; set; }
        /// <summary>
        /// Valor retido do INSS
        /// </summary>
        /// <value>Valor retido do INSS</value>
        [DataMember(Name="inssAmountWithheld", EmitDefaultValue=false)]
        public double? InssAmountWithheld { get; set; }
        /// <summary>
        /// Valor retido do ISS
        /// </summary>
        /// <value>Valor retido do ISS</value>
        [DataMember(Name="issAmountWithheld", EmitDefaultValue=false)]
        public double? IssAmountWithheld { get; set; }
        /// <summary>
        /// Valor de outras retenções
        /// </summary>
        /// <value>Valor de outras retenções</value>
        [DataMember(Name="othersAmountWithheld", EmitDefaultValue=false)]
        public double? OthersAmountWithheld { get; set; }
        /// <summary>
        /// Tributos aproximados
        /// </summary>
        /// <value>Tributos aproximados</value>
        [DataMember(Name="approximateTax", EmitDefaultValue=false)]
        public ServiceInvoiceApproximateTaxesResource ApproximateTax { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceInvoiceIssueMessage {\n");
            sb.Append("  Borrower: ").Append(Borrower).Append("\n");
            sb.Append("  CityServiceCode: ").Append(CityServiceCode).Append("\n");
            sb.Append("  FederalServiceCode: ").Append(FederalServiceCode).Append("\n");
            sb.Append("  CnaeCode: ").Append(CnaeCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ServicesAmount: ").Append(ServicesAmount).Append("\n");
            sb.Append("  RpsSerialNumber: ").Append(RpsSerialNumber).Append("\n");
            sb.Append("  IssuedOn: ").Append(IssuedOn).Append("\n");
            sb.Append("  RpsNumber: ").Append(RpsNumber).Append("\n");
            sb.Append("  TaxationType: ").Append(TaxationType).Append("\n");
            sb.Append("  IssRate: ").Append(IssRate).Append("\n");
            sb.Append("  IssTaxAmount: ").Append(IssTaxAmount).Append("\n");
            sb.Append("  DeductionsAmount: ").Append(DeductionsAmount).Append("\n");
            sb.Append("  DiscountUnconditionedAmount: ").Append(DiscountUnconditionedAmount).Append("\n");
            sb.Append("  DiscountConditionedAmount: ").Append(DiscountConditionedAmount).Append("\n");
            sb.Append("  IrAmountWithheld: ").Append(IrAmountWithheld).Append("\n");
            sb.Append("  PisAmountWithheld: ").Append(PisAmountWithheld).Append("\n");
            sb.Append("  CofinsAmountWithheld: ").Append(CofinsAmountWithheld).Append("\n");
            sb.Append("  CsllAmountWithheld: ").Append(CsllAmountWithheld).Append("\n");
            sb.Append("  InssAmountWithheld: ").Append(InssAmountWithheld).Append("\n");
            sb.Append("  IssAmountWithheld: ").Append(IssAmountWithheld).Append("\n");
            sb.Append("  OthersAmountWithheld: ").Append(OthersAmountWithheld).Append("\n");
            sb.Append("  ApproximateTax: ").Append(ApproximateTax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ServiceInvoiceIssueMessage);
        }

        /// <summary>
        /// Returns true if ServiceInvoiceIssueMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceInvoiceIssueMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceInvoiceIssueMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Borrower == other.Borrower ||
                    this.Borrower != null &&
                    this.Borrower.Equals(other.Borrower)
                ) && 
                (
                    this.CityServiceCode == other.CityServiceCode ||
                    this.CityServiceCode != null &&
                    this.CityServiceCode.Equals(other.CityServiceCode)
                ) && 
                (
                    this.FederalServiceCode == other.FederalServiceCode ||
                    this.FederalServiceCode != null &&
                    this.FederalServiceCode.Equals(other.FederalServiceCode)
                ) && 
                (
                    this.CnaeCode == other.CnaeCode ||
                    this.CnaeCode != null &&
                    this.CnaeCode.Equals(other.CnaeCode)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.ServicesAmount == other.ServicesAmount ||
                    this.ServicesAmount != null &&
                    this.ServicesAmount.Equals(other.ServicesAmount)
                ) && 
                (
                    this.RpsSerialNumber == other.RpsSerialNumber ||
                    this.RpsSerialNumber != null &&
                    this.RpsSerialNumber.Equals(other.RpsSerialNumber)
                ) && 
                (
                    this.IssuedOn == other.IssuedOn ||
                    this.IssuedOn != null &&
                    this.IssuedOn.Equals(other.IssuedOn)
                ) && 
                (
                    this.RpsNumber == other.RpsNumber ||
                    this.RpsNumber != null &&
                    this.RpsNumber.Equals(other.RpsNumber)
                ) && 
                (
                    this.TaxationType == other.TaxationType ||
                    this.TaxationType != null &&
                    this.TaxationType.Equals(other.TaxationType)
                ) && 
                (
                    this.IssRate == other.IssRate ||
                    this.IssRate != null &&
                    this.IssRate.Equals(other.IssRate)
                ) && 
                (
                    this.IssTaxAmount == other.IssTaxAmount ||
                    this.IssTaxAmount != null &&
                    this.IssTaxAmount.Equals(other.IssTaxAmount)
                ) && 
                (
                    this.DeductionsAmount == other.DeductionsAmount ||
                    this.DeductionsAmount != null &&
                    this.DeductionsAmount.Equals(other.DeductionsAmount)
                ) && 
                (
                    this.DiscountUnconditionedAmount == other.DiscountUnconditionedAmount ||
                    this.DiscountUnconditionedAmount != null &&
                    this.DiscountUnconditionedAmount.Equals(other.DiscountUnconditionedAmount)
                ) && 
                (
                    this.DiscountConditionedAmount == other.DiscountConditionedAmount ||
                    this.DiscountConditionedAmount != null &&
                    this.DiscountConditionedAmount.Equals(other.DiscountConditionedAmount)
                ) && 
                (
                    this.IrAmountWithheld == other.IrAmountWithheld ||
                    this.IrAmountWithheld != null &&
                    this.IrAmountWithheld.Equals(other.IrAmountWithheld)
                ) && 
                (
                    this.PisAmountWithheld == other.PisAmountWithheld ||
                    this.PisAmountWithheld != null &&
                    this.PisAmountWithheld.Equals(other.PisAmountWithheld)
                ) && 
                (
                    this.CofinsAmountWithheld == other.CofinsAmountWithheld ||
                    this.CofinsAmountWithheld != null &&
                    this.CofinsAmountWithheld.Equals(other.CofinsAmountWithheld)
                ) && 
                (
                    this.CsllAmountWithheld == other.CsllAmountWithheld ||
                    this.CsllAmountWithheld != null &&
                    this.CsllAmountWithheld.Equals(other.CsllAmountWithheld)
                ) && 
                (
                    this.InssAmountWithheld == other.InssAmountWithheld ||
                    this.InssAmountWithheld != null &&
                    this.InssAmountWithheld.Equals(other.InssAmountWithheld)
                ) && 
                (
                    this.IssAmountWithheld == other.IssAmountWithheld ||
                    this.IssAmountWithheld != null &&
                    this.IssAmountWithheld.Equals(other.IssAmountWithheld)
                ) && 
                (
                    this.OthersAmountWithheld == other.OthersAmountWithheld ||
                    this.OthersAmountWithheld != null &&
                    this.OthersAmountWithheld.Equals(other.OthersAmountWithheld)
                ) && 
                (
                    this.ApproximateTax == other.ApproximateTax ||
                    this.ApproximateTax != null &&
                    this.ApproximateTax.Equals(other.ApproximateTax)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Borrower != null)
                    hash = hash * 59 + this.Borrower.GetHashCode();
                if (this.CityServiceCode != null)
                    hash = hash * 59 + this.CityServiceCode.GetHashCode();
                if (this.FederalServiceCode != null)
                    hash = hash * 59 + this.FederalServiceCode.GetHashCode();
                if (this.CnaeCode != null)
                    hash = hash * 59 + this.CnaeCode.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.ServicesAmount != null)
                    hash = hash * 59 + this.ServicesAmount.GetHashCode();
                if (this.RpsSerialNumber != null)
                    hash = hash * 59 + this.RpsSerialNumber.GetHashCode();
                if (this.IssuedOn != null)
                    hash = hash * 59 + this.IssuedOn.GetHashCode();
                if (this.RpsNumber != null)
                    hash = hash * 59 + this.RpsNumber.GetHashCode();
                if (this.TaxationType != null)
                    hash = hash * 59 + this.TaxationType.GetHashCode();
                if (this.IssRate != null)
                    hash = hash * 59 + this.IssRate.GetHashCode();
                if (this.IssTaxAmount != null)
                    hash = hash * 59 + this.IssTaxAmount.GetHashCode();
                if (this.DeductionsAmount != null)
                    hash = hash * 59 + this.DeductionsAmount.GetHashCode();
                if (this.DiscountUnconditionedAmount != null)
                    hash = hash * 59 + this.DiscountUnconditionedAmount.GetHashCode();
                if (this.DiscountConditionedAmount != null)
                    hash = hash * 59 + this.DiscountConditionedAmount.GetHashCode();
                if (this.IrAmountWithheld != null)
                    hash = hash * 59 + this.IrAmountWithheld.GetHashCode();
                if (this.PisAmountWithheld != null)
                    hash = hash * 59 + this.PisAmountWithheld.GetHashCode();
                if (this.CofinsAmountWithheld != null)
                    hash = hash * 59 + this.CofinsAmountWithheld.GetHashCode();
                if (this.CsllAmountWithheld != null)
                    hash = hash * 59 + this.CsllAmountWithheld.GetHashCode();
                if (this.InssAmountWithheld != null)
                    hash = hash * 59 + this.InssAmountWithheld.GetHashCode();
                if (this.IssAmountWithheld != null)
                    hash = hash * 59 + this.IssAmountWithheld.GetHashCode();
                if (this.OthersAmountWithheld != null)
                    hash = hash * 59 + this.OthersAmountWithheld.GetHashCode();
                if (this.ApproximateTax != null)
                    hash = hash * 59 + this.ApproximateTax.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
