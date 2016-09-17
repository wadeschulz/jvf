using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HelixDataSci.Genomics
{
    public class JvfCaseModel
    {
        [JsonProperty(PropertyName = "subject_uri")]
        public string SubjectUri { get; set; }

        [JsonProperty(PropertyName = "subject_days_old_at_collection")]
        public int? SubjectDaysOldAtCollection { get; set; }

        [JsonProperty(PropertyName = "subject_dob")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime? SubjectDob { get; set; }

        [JsonProperty(PropertyName = "parental_specimen_uris")]
        public List<string> ParentalSpecimenUris { get; set; }

        [JsonProperty(PropertyName = "germline_specimen_uri")]
        public string GermlineSpecimenUri { get; set; }

        [JsonProperty(PropertyName = "specimen_uri")]
        public string SpecimenUri { get; set; }

        [JsonProperty(PropertyName = "panel_uri")]
        public string PanelUri { get; set; }

        [JsonProperty(PropertyName = "file_hash")]
        public string FileHash { get; set; }

        [JsonProperty(PropertyName = "order_dx")]
        public string OrderDx { get; set; }

        [JsonProperty(PropertyName = "order_dx_cat")]
        public string OrderDxCat { get; set; }

        [JsonProperty(PropertyName = "specimen_type")]
        public string SpecimenType { get; set; }

        [JsonProperty(PropertyName = "therapy_relationship")]
        public string TherapyRelationship { get; set; }

        [JsonProperty(PropertyName = "sample_differentiator")]
        public string SampleDifferentiator { get; set; }

        [JsonProperty(PropertyName = "specimen_cat")]
        public string SpecimenCategory { get; set; }

        [JsonProperty(PropertyName = "specimen_site")]
        public string SpecimenSite { get; set; }

        [JsonProperty(PropertyName = "specimen_subsite")]
        public string SpecimenSubsite { get; set; }

        [JsonProperty(PropertyName = "specimen_histology")]
        public string SpecimenHistology { get; set; }

        [JsonProperty(PropertyName = "specimen_histology_subtype")]
        public string SpecimenHistologySubtype { get; set; }

        [JsonProperty(PropertyName = "collected_date")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime? CollectedDate { get; set; }

        [JsonProperty(PropertyName = "preparation_date")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime? PreparationDate { get; set; }

        [JsonProperty(PropertyName = "sequenced_date")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime? SequencedDate { get; set; }

        [JsonProperty(PropertyName = "interped_date")]
        [JsonConverter(typeof(JavaScriptDateTimeConverter))]
        public DateTime? InterpedDate { get; set; }

        [JsonProperty(PropertyName = "instrument_type")]
        public string InstrumentType { get; set; }

        [JsonProperty(PropertyName = "seq_method")]
        public string SeqMethod { get; set; }

        [JsonProperty(PropertyName = "seq_org_uri")]
        public string SeqOrgUri { get; set; }

        [JsonProperty(PropertyName = "pipeline_uri")]
        public string PipelineUri { get; set; }

        [JsonProperty(PropertyName = "ref_genome")]
        public string RefGenome { get; set; }

        [JsonProperty(PropertyName = "is_clinical_specimen")]
        public bool? IsClinicalSpecimen { get; set; }

        [JsonProperty(PropertyName = "is_germline_specimen")]
        public bool? IsGermlineSpecimen { get; set; }

        [JsonProperty(PropertyName = "is_history_complete")]
        public bool? IsHistoryComplete { get; set; }

        [JsonProperty(PropertyName = "estimated_tumor_fraction")]
        public double? EstimatedTumorFraction { get; set; }

        [JsonProperty(PropertyName = "estimated_necrosis_fraction")]
        public double? EstimatedNecrosisFraction { get; set; }

        [JsonProperty(PropertyName = "specimen_description")]
        public string SpecimenDescription { get; set; }

        [JsonProperty(PropertyName = "ploidy_threshold")]
        public double? PloidyThreshold { get; set; }

        [JsonProperty(PropertyName = "tumor_freq_threshold")]
        public double? TumorFreqThreshold { get; set; }

        [JsonProperty(PropertyName = "regions_covered")]
        public List<RegionsCovered> RegionsCovered { get; set; }

        [JsonProperty(PropertyName = "research_source")]
        public string ResearchSource { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "interpretation")]
        public string Interpretation { get; set; }

        [JsonProperty(PropertyName = "total_variants")]
        public int? TotalVariants { get; set; }

        [JsonProperty(PropertyName = "total_reported_variants")]
        public int? TotalReportedVariants { get; set; }

        [JsonProperty(PropertyName = "germline_variants")]
        public int? GermlineVariants { get; set; }

        [JsonProperty(PropertyName = "somatic_variants")]
        public int? SomaticVariants { get; set; }

        [JsonProperty(PropertyName = "variant_locations")]
        public List<VariantLocation> VariantLocations { get; set; }

        [JsonProperty(PropertyName = "vcf_file")]
        public string VcfFile { get; set; }

        [JsonProperty(PropertyName = "variants")]
        public List<JvfVariantModel> Variants { get; set; } 
    }

    public class JvfVariantModel
    {
        [JsonProperty(PropertyName = "ref_genome")]
        public string ReferenceGenome { get; set; }

        [JsonProperty(PropertyName = "chr")]
        public string Chromosome { get; set; }

        [JsonProperty(PropertyName = "loc")]
        public int? Location { get; set; }

        [JsonProperty(PropertyName = "rsid")]
        public string Rsid { get; set; }

        [JsonProperty(PropertyName = "ref_allele")]
        public string ReferenceAllele { get; set; }

        [JsonProperty(PropertyName = "num_alt_alleles")]
        public int? NumAltAlleles { get; set; }

        [JsonProperty(PropertyName = "alt_allele")]
        public string Alt { get; set; }

        [JsonProperty(PropertyName = "qual")]
        public int? Qual { get; set; }

        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        [JsonProperty(PropertyName = "depth")]
        public int? Depth { get; set; }

        [JsonProperty(PropertyName = "reads_forw")]
        public int? ReadsForw { get; set; }

        [JsonProperty(PropertyName = "reads_rev")]
        public int? ReadsRev { get; set; }

        [JsonProperty(PropertyName = "reads_ref_allele")]
        public int? ReadsRef { get; set; }

        [JsonProperty(PropertyName = "reads_ref_forw")]
        public int? ReadsRefForw { get; set; }

        [JsonProperty(PropertyName = "reads_ref_rev")]
        public int? ReadsRefRev { get; set; }

        [JsonProperty(PropertyName = "reads_alt_allele")]
        public int? ReadsAlt { get; set; }

        [JsonProperty(PropertyName = "reads_alt_forw")]
        public int? ReadsAltForw { get; set; }

        [JsonProperty(PropertyName = "reads_alt_rev")]
        public int? ReadsAltRev { get; set; }

        [JsonProperty(PropertyName = "strand_bias_forw")]
        public double? StrandBiasForw { get; set; }

        [JsonProperty(PropertyName = "strand_bias_rev")]
        public double? StrandBiasRev { get; set; }

        [JsonProperty(PropertyName = "strand_bias")]
        public double? StrandBias { get; set; }

        [JsonProperty(PropertyName = "flow_depth")]
        public int? FlowDepth { get; set; }

        [JsonProperty(PropertyName = "flow_reads_forw")]
        public int? FlowReadsForw { get; set; }

        [JsonProperty(PropertyName = "flow_reads_rev")]
        public int? FlowReadsRev { get; set; }

        [JsonProperty(PropertyName = "flow_reads_ref_allele")]
        public int? FlowReadsRef { get; set; }

        [JsonProperty(PropertyName = "flow_reads_ref_forw")]
        public int? FlowReadsRefForw { get; set; }

        [JsonProperty(PropertyName = "flow_reads_ref_rev")]
        public int? FlowReadsRefRev { get; set; }

        [JsonProperty(PropertyName = "flow_reads_alt_allele")]
        public int? FlowReadsAlt { get; set; }

        [JsonProperty(PropertyName = "flow_reads_alt_forw")]
        public int? FlowReadsAltForw { get; set; }

        [JsonProperty(PropertyName = "flow_reads_alt_rev")]
        public int? FlowReadsAltRev { get; set; }

        [JsonProperty(PropertyName = "af_total")]
        public double? AfTotal { get; set; }

        [JsonProperty(PropertyName = "af_specific")]
        public double? AfSpecific { get; set; }

        [JsonProperty(PropertyName = "var_type")]
        public string VarType { get; set; }

        [JsonProperty(PropertyName = "var_gene_region")]
        public string VarGeneRegion { get; set; }

        [JsonProperty(PropertyName = "var_effect")]
        public string VarEffect { get; set; }

        [JsonProperty(PropertyName = "gene")]
        public string Gene { get; set; }

        [JsonProperty(PropertyName = "transcript")]
        public string Transcript { get; set; }

        [JsonProperty(PropertyName = "exon")]
        public int? Exon { get; set; }

        [JsonProperty(PropertyName = "hgvs_protein")]
        public string HgvsProtein { get; set; }

        [JsonProperty(PropertyName = "hgvs_coding")]
        public string HgvsCoding { get; set; }

        [JsonProperty(PropertyName = "is_actionable")]
        public bool? IsActionable { get; set; }

        [JsonProperty(PropertyName = "interpretation")]
        public string Interpretation { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "somatic_status")]
        public string SomaticStatus { get; set; }
    }

    public class RegionsCovered
    {
        [JsonProperty(PropertyName = "chr")]
        public string Chromosome { get; set; }
        [JsonProperty(PropertyName = "start")]
        public int? Start { get; set; }
        [JsonProperty(PropertyName = "end")]
        public int? End { get; set; }
    }

    public class VariantLocation
    {
        [JsonProperty(PropertyName = "chr")]
        public string Chromosome { get; set; }
        [JsonProperty(PropertyName = "loc")]
        public int? Location { get; set; }
        [JsonProperty(PropertyName = "ref_allele")]
        public string RefAllele { get; set; }
        [JsonProperty(PropertyName = "alt_alleles")]
        public List<string> AltAlleles { get; set; }
    }
}