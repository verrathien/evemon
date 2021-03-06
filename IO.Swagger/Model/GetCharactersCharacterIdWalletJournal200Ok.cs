/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.5.5
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdWalletJournal200Ok :  IEquatable<GetCharactersCharacterIdWalletJournal200Ok>, IValidatableObject
    {
        /// <summary>
        /// first_party_type string
        /// </summary>
        /// <value>first_party_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FirstPartyTypeEnum
        {
            
            /// <summary>
            /// Enum Character for "character"
            /// </summary>
            [EnumMember(Value = "character")]
            Character,
            
            /// <summary>
            /// Enum Corporation for "corporation"
            /// </summary>
            [EnumMember(Value = "corporation")]
            Corporation,
            
            /// <summary>
            /// Enum Alliance for "alliance"
            /// </summary>
            [EnumMember(Value = "alliance")]
            Alliance,
            
            /// <summary>
            /// Enum Faction for "faction"
            /// </summary>
            [EnumMember(Value = "faction")]
            Faction
        }

        /// <summary>
        /// Transaction type, different type of transaction will populate different fields in &#x60;extra_info&#x60;
        /// </summary>
        /// <value>Transaction type, different type of transaction will populate different fields in &#x60;extra_info&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefTypeEnum
        {
            
            /// <summary>
            /// Enum Playertrading for "player_trading"
            /// </summary>
            [EnumMember(Value = "player_trading")]
            Playertrading,
            
            /// <summary>
            /// Enum Markettransaction for "market_transaction"
            /// </summary>
            [EnumMember(Value = "market_transaction")]
            Markettransaction,
            
            /// <summary>
            /// Enum Playerdonation for "player_donation"
            /// </summary>
            [EnumMember(Value = "player_donation")]
            Playerdonation,
            
            /// <summary>
            /// Enum Officerentalfee for "office_rental_fee"
            /// </summary>
            [EnumMember(Value = "office_rental_fee")]
            Officerentalfee,
            
            /// <summary>
            /// Enum Bountyprizehistorical for "bounty_prize_historical"
            /// </summary>
            [EnumMember(Value = "bounty_prize_historical")]
            Bountyprizehistorical,
            
            /// <summary>
            /// Enum Insurance for "insurance"
            /// </summary>
            [EnumMember(Value = "insurance")]
            Insurance,
            
            /// <summary>
            /// Enum Missionreward for "mission_reward"
            /// </summary>
            [EnumMember(Value = "mission_reward")]
            Missionreward,
            
            /// <summary>
            /// Enum Missionrewardbonus for "mission_reward_bonus"
            /// </summary>
            [EnumMember(Value = "mission_reward_bonus")]
            Missionrewardbonus,
            
            /// <summary>
            /// Enum Cspa for "cspa"
            /// </summary>
            [EnumMember(Value = "cspa")]
            Cspa,
            
            /// <summary>
            /// Enum Corpaccountwithdrawal for "corp_account_withdrawal"
            /// </summary>
            [EnumMember(Value = "corp_account_withdrawal")]
            Corpaccountwithdrawal,
            
            /// <summary>
            /// Enum Logochangefee for "logo_change_fee"
            /// </summary>
            [EnumMember(Value = "logo_change_fee")]
            Logochangefee,
            
            /// <summary>
            /// Enum Marketescrow for "market_escrow"
            /// </summary>
            [EnumMember(Value = "market_escrow")]
            Marketescrow,
            
            /// <summary>
            /// Enum Brokerfee for "broker_fee"
            /// </summary>
            [EnumMember(Value = "broker_fee")]
            Brokerfee,
            
            /// <summary>
            /// Enum Alliancemaintenancefee for "alliance_maintenance_fee"
            /// </summary>
            [EnumMember(Value = "alliance_maintenance_fee")]
            Alliancemaintenancefee,
            
            /// <summary>
            /// Enum Salestax for "sales_tax"
            /// </summary>
            [EnumMember(Value = "sales_tax")]
            Salestax,
            
            /// <summary>
            /// Enum Jumpcloneinstallationfee for "jump_clone_installation_fee"
            /// </summary>
            [EnumMember(Value = "jump_clone_installation_fee")]
            Jumpcloneinstallationfee,
            
            /// <summary>
            /// Enum Manufacturing for "manufacturing"
            /// </summary>
            [EnumMember(Value = "manufacturing")]
            Manufacturing,
            
            /// <summary>
            /// Enum Contract for "contract"
            /// </summary>
            [EnumMember(Value = "contract")]
            Contract,
            
            /// <summary>
            /// Enum Bountyprizes for "bounty_prizes"
            /// </summary>
            [EnumMember(Value = "bounty_prizes")]
            Bountyprizes,
            
            /// <summary>
            /// Enum Medalcreationfee for "medal_creation_fee"
            /// </summary>
            [EnumMember(Value = "medal_creation_fee")]
            Medalcreationfee,
            
            /// <summary>
            /// Enum Medalissuingfee for "medal_issuing_fee"
            /// </summary>
            [EnumMember(Value = "medal_issuing_fee")]
            Medalissuingfee,
            
            /// <summary>
            /// Enum Customsofficeimportduty for "customs_office_import_duty"
            /// </summary>
            [EnumMember(Value = "customs_office_import_duty")]
            Customsofficeimportduty,
            
            /// <summary>
            /// Enum Customsofficeexportduty for "customs_office_export_duty"
            /// </summary>
            [EnumMember(Value = "customs_office_export_duty")]
            Customsofficeexportduty,
            
            /// <summary>
            /// Enum Corporaterewardpayout for "corporate_reward_payout"
            /// </summary>
            [EnumMember(Value = "corporate_reward_payout")]
            Corporaterewardpayout,
            
            /// <summary>
            /// Enum Industryfacilitytax for "industry_facility_tax"
            /// </summary>
            [EnumMember(Value = "industry_facility_tax")]
            Industryfacilitytax,
            
            /// <summary>
            /// Enum Projectdiscoveryreward for "project_discovery_reward"
            /// </summary>
            [EnumMember(Value = "project_discovery_reward")]
            Projectdiscoveryreward,
            
            /// <summary>
            /// Enum Reprocessingfee for "reprocessing_fee"
            /// </summary>
            [EnumMember(Value = "reprocessing_fee")]
            Reprocessingfee,
            
            /// <summary>
            /// Enum Jumpcloneactivationfee for "jump_clone_activation_fee"
            /// </summary>
            [EnumMember(Value = "jump_clone_activation_fee")]
            Jumpcloneactivationfee,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown
        }

        /// <summary>
        /// second_party_type string
        /// </summary>
        /// <value>second_party_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SecondPartyTypeEnum
        {
            
            /// <summary>
            /// Enum Character for "character"
            /// </summary>
            [EnumMember(Value = "character")]
            Character,
            
            /// <summary>
            /// Enum Corporation for "corporation"
            /// </summary>
            [EnumMember(Value = "corporation")]
            Corporation,
            
            /// <summary>
            /// Enum Alliance for "alliance"
            /// </summary>
            [EnumMember(Value = "alliance")]
            Alliance,
            
            /// <summary>
            /// Enum Faction for "faction"
            /// </summary>
            [EnumMember(Value = "faction")]
            Faction
        }

        /// <summary>
        /// first_party_type string
        /// </summary>
        /// <value>first_party_type string</value>
        [DataMember(Name="first_party_type", EmitDefaultValue=false)]
        public FirstPartyTypeEnum? FirstPartyType { get; set; }
        /// <summary>
        /// Transaction type, different type of transaction will populate different fields in &#x60;extra_info&#x60;
        /// </summary>
        /// <value>Transaction type, different type of transaction will populate different fields in &#x60;extra_info&#x60;</value>
        [DataMember(Name="ref_type", EmitDefaultValue=false)]
        public RefTypeEnum? RefType { get; set; }
        /// <summary>
        /// second_party_type string
        /// </summary>
        /// <value>second_party_type string</value>
        [DataMember(Name="second_party_type", EmitDefaultValue=false)]
        public SecondPartyTypeEnum? SecondPartyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdWalletJournal200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdWalletJournal200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdWalletJournal200Ok" /> class.
        /// </summary>
        /// <param name="Amount">Transaction amount. Positive when value transferred to the first party. Negative otherwise.</param>
        /// <param name="Balance">Wallet balance after transaction occurred.</param>
        /// <param name="Date">Date and time of transaction (required).</param>
        /// <param name="ExtraInfo">ExtraInfo.</param>
        /// <param name="FirstPartyId">first_party_id integer.</param>
        /// <param name="FirstPartyType">first_party_type string.</param>
        /// <param name="Reason">reason string.</param>
        /// <param name="RefId">Unique journal reference ID (required).</param>
        /// <param name="RefType">Transaction type, different type of transaction will populate different fields in &#x60;extra_info&#x60; (required).</param>
        /// <param name="SecondPartyId">second_party_id integer.</param>
        /// <param name="SecondPartyType">second_party_type string.</param>
        /// <param name="Tax">Tax amount received for tax related transactions.</param>
        /// <param name="TaxRecieverId">the corporation ID receiving any tax paid.</param>
        public GetCharactersCharacterIdWalletJournal200Ok(float? Amount = default(float?), float? Balance = default(float?), DateTime? Date = default(DateTime?), GetCharactersCharacterIdWalletJournalExtraInfo ExtraInfo = default(GetCharactersCharacterIdWalletJournalExtraInfo), int? FirstPartyId = default(int?), FirstPartyTypeEnum? FirstPartyType = default(FirstPartyTypeEnum?), string Reason = default(string), long? RefId = default(long?), RefTypeEnum? RefType = default(RefTypeEnum?), int? SecondPartyId = default(int?), SecondPartyTypeEnum? SecondPartyType = default(SecondPartyTypeEnum?), float? Tax = default(float?), int? TaxRecieverId = default(int?))
        {
            // to ensure "Date" is required (not null)
            if (Date == null)
            {
                throw new InvalidDataException("Date is a required property for GetCharactersCharacterIdWalletJournal200Ok and cannot be null");
            }
            else
            {
                this.Date = Date;
            }
            // to ensure "RefId" is required (not null)
            if (RefId == null)
            {
                throw new InvalidDataException("RefId is a required property for GetCharactersCharacterIdWalletJournal200Ok and cannot be null");
            }
            else
            {
                this.RefId = RefId;
            }
            // to ensure "RefType" is required (not null)
            if (RefType == null)
            {
                throw new InvalidDataException("RefType is a required property for GetCharactersCharacterIdWalletJournal200Ok and cannot be null");
            }
            else
            {
                this.RefType = RefType;
            }
            this.Amount = Amount;
            this.Balance = Balance;
            this.ExtraInfo = ExtraInfo;
            this.FirstPartyId = FirstPartyId;
            this.FirstPartyType = FirstPartyType;
            this.Reason = Reason;
            this.SecondPartyId = SecondPartyId;
            this.SecondPartyType = SecondPartyType;
            this.Tax = Tax;
            this.TaxRecieverId = TaxRecieverId;
        }
        
        /// <summary>
        /// Transaction amount. Positive when value transferred to the first party. Negative otherwise
        /// </summary>
        /// <value>Transaction amount. Positive when value transferred to the first party. Negative otherwise</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public float? Amount { get; set; }

        /// <summary>
        /// Wallet balance after transaction occurred
        /// </summary>
        /// <value>Wallet balance after transaction occurred</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public float? Balance { get; set; }

        /// <summary>
        /// Date and time of transaction
        /// </summary>
        /// <value>Date and time of transaction</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets ExtraInfo
        /// </summary>
        [DataMember(Name="extra_info", EmitDefaultValue=false)]
        public GetCharactersCharacterIdWalletJournalExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// first_party_id integer
        /// </summary>
        /// <value>first_party_id integer</value>
        [DataMember(Name="first_party_id", EmitDefaultValue=false)]
        public int? FirstPartyId { get; set; }


        /// <summary>
        /// reason string
        /// </summary>
        /// <value>reason string</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Unique journal reference ID
        /// </summary>
        /// <value>Unique journal reference ID</value>
        [DataMember(Name="ref_id", EmitDefaultValue=false)]
        public long? RefId { get; set; }


        /// <summary>
        /// second_party_id integer
        /// </summary>
        /// <value>second_party_id integer</value>
        [DataMember(Name="second_party_id", EmitDefaultValue=false)]
        public int? SecondPartyId { get; set; }


        /// <summary>
        /// Tax amount received for tax related transactions
        /// </summary>
        /// <value>Tax amount received for tax related transactions</value>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public float? Tax { get; set; }

        /// <summary>
        /// the corporation ID receiving any tax paid
        /// </summary>
        /// <value>the corporation ID receiving any tax paid</value>
        [DataMember(Name="tax_reciever_id", EmitDefaultValue=false)]
        public int? TaxRecieverId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdWalletJournal200Ok {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  ExtraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  FirstPartyId: ").Append(FirstPartyId).Append("\n");
            sb.Append("  FirstPartyType: ").Append(FirstPartyType).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  RefId: ").Append(RefId).Append("\n");
            sb.Append("  RefType: ").Append(RefType).Append("\n");
            sb.Append("  SecondPartyId: ").Append(SecondPartyId).Append("\n");
            sb.Append("  SecondPartyType: ").Append(SecondPartyType).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  TaxRecieverId: ").Append(TaxRecieverId).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetCharactersCharacterIdWalletJournal200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdWalletJournal200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdWalletJournal200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdWalletJournal200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.ExtraInfo == input.ExtraInfo ||
                    (this.ExtraInfo != null &&
                    this.ExtraInfo.Equals(input.ExtraInfo))
                ) && 
                (
                    this.FirstPartyId == input.FirstPartyId ||
                    (this.FirstPartyId != null &&
                    this.FirstPartyId.Equals(input.FirstPartyId))
                ) && 
                (
                    this.FirstPartyType == input.FirstPartyType ||
                    (this.FirstPartyType != null &&
                    this.FirstPartyType.Equals(input.FirstPartyType))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.RefId == input.RefId ||
                    (this.RefId != null &&
                    this.RefId.Equals(input.RefId))
                ) && 
                (
                    this.RefType == input.RefType ||
                    (this.RefType != null &&
                    this.RefType.Equals(input.RefType))
                ) && 
                (
                    this.SecondPartyId == input.SecondPartyId ||
                    (this.SecondPartyId != null &&
                    this.SecondPartyId.Equals(input.SecondPartyId))
                ) && 
                (
                    this.SecondPartyType == input.SecondPartyType ||
                    (this.SecondPartyType != null &&
                    this.SecondPartyType.Equals(input.SecondPartyType))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.TaxRecieverId == input.TaxRecieverId ||
                    (this.TaxRecieverId != null &&
                    this.TaxRecieverId.Equals(input.TaxRecieverId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.ExtraInfo != null)
                    hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.FirstPartyId != null)
                    hashCode = hashCode * 59 + this.FirstPartyId.GetHashCode();
                if (this.FirstPartyType != null)
                    hashCode = hashCode * 59 + this.FirstPartyType.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.RefId != null)
                    hashCode = hashCode * 59 + this.RefId.GetHashCode();
                if (this.RefType != null)
                    hashCode = hashCode * 59 + this.RefType.GetHashCode();
                if (this.SecondPartyId != null)
                    hashCode = hashCode * 59 + this.SecondPartyId.GetHashCode();
                if (this.SecondPartyType != null)
                    hashCode = hashCode * 59 + this.SecondPartyType.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.TaxRecieverId != null)
                    hashCode = hashCode * 59 + this.TaxRecieverId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
