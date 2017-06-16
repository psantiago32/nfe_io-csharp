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
    /// NaturalPersonResource
    /// </summary>
    [DataContract]
    public partial class NaturalPersonResource :  IEquatable<NaturalPersonResource>, IValidatableObject
    {
        /// <summary>
        /// Status no sistema
        /// </summary>
        /// <value>Status no sistema</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active
        }

        /// <summary>
        /// Status no sistema
        /// </summary>
        /// <value>Status no sistema</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalPersonResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NaturalPersonResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalPersonResource" /> class.
        /// </summary>
        /// <param name="Id">Identificação.</param>
        /// <param name="Name">Nome completo (required).</param>
        /// <param name="FederalTaxNumber">CPF.</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="Address">Endereço (required).</param>
        /// <param name="BirthDate">Data nascimento.</param>
        /// <param name="IdNumber">Número do Registro Geral (RG).</param>
        /// <param name="Status">Status no sistema.</param>
        /// <param name="CreatedOn">Data de criação.</param>
        /// <param name="ModifiedOn">Data da última modificação.</param>
        public NaturalPersonResource(string Id = default(string), string Name = default(string), long? FederalTaxNumber = default(long?), string Email = default(string), Address Address = default(Address), DateTime? BirthDate = default(DateTime?), string IdNumber = default(string), StatusEnum? Status = default(StatusEnum?), DateTime? CreatedOn = default(DateTime?), DateTime? ModifiedOn = default(DateTime?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for NaturalPersonResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for NaturalPersonResource and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for NaturalPersonResource and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            this.Id = Id;
            this.FederalTaxNumber = FederalTaxNumber;
            this.BirthDate = BirthDate;
            this.IdNumber = IdNumber;
            this.Status = Status;
            this.CreatedOn = CreatedOn;
            this.ModifiedOn = ModifiedOn;
        }
        
        /// <summary>
        /// Identificação
        /// </summary>
        /// <value>Identificação</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Nome completo
        /// </summary>
        /// <value>Nome completo</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// CPF
        /// </summary>
        /// <value>CPF</value>
        [DataMember(Name="federalTaxNumber", EmitDefaultValue=false)]
        public long? FederalTaxNumber { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Endereço
        /// </summary>
        /// <value>Endereço</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }
        /// <summary>
        /// Data nascimento
        /// </summary>
        /// <value>Data nascimento</value>
        [DataMember(Name="birthDate", EmitDefaultValue=false)]
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Número do Registro Geral (RG)
        /// </summary>
        /// <value>Número do Registro Geral (RG)</value>
        [DataMember(Name="idNumber", EmitDefaultValue=false)]
        public string IdNumber { get; set; }
        /// <summary>
        /// Data de criação
        /// </summary>
        /// <value>Data de criação</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Data da última modificação
        /// </summary>
        /// <value>Data da última modificação</value>
        [DataMember(Name="modifiedOn", EmitDefaultValue=false)]
        public DateTime? ModifiedOn { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NaturalPersonResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FederalTaxNumber: ").Append(FederalTaxNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
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
            return this.Equals(obj as NaturalPersonResource);
        }

        /// <summary>
        /// Returns true if NaturalPersonResource instances are equal
        /// </summary>
        /// <param name="other">Instance of NaturalPersonResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NaturalPersonResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FederalTaxNumber == other.FederalTaxNumber ||
                    this.FederalTaxNumber != null &&
                    this.FederalTaxNumber.Equals(other.FederalTaxNumber)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.BirthDate == other.BirthDate ||
                    this.BirthDate != null &&
                    this.BirthDate.Equals(other.BirthDate)
                ) && 
                (
                    this.IdNumber == other.IdNumber ||
                    this.IdNumber != null &&
                    this.IdNumber.Equals(other.IdNumber)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.ModifiedOn == other.ModifiedOn ||
                    this.ModifiedOn != null &&
                    this.ModifiedOn.Equals(other.ModifiedOn)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.FederalTaxNumber != null)
                    hash = hash * 59 + this.FederalTaxNumber.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.BirthDate != null)
                    hash = hash * 59 + this.BirthDate.GetHashCode();
                if (this.IdNumber != null)
                    hash = hash * 59 + this.IdNumber.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.ModifiedOn != null)
                    hash = hash * 59 + this.ModifiedOn.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
