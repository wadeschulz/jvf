# jvf
JSON Variant Format

JSON represenation of genomic variants for use in web services and document-oriented data structures.

# Document URIs
Used to identify specific organizations/laboratories using a reverse FQDN.

OrganizationUri:
	/organization/org.ynhh.labmed
	/organization/org.ynhh.pathology
	
SubjectURI: 
  External: /subject/orgid/identifier
  
SpecimenURI:
	Lab medicine: /specimen/orgid/caseid
	
PanelURI:
	AML: /panel/orgid/panelid/YEARDEVELOPED
	
SpecimenCat:
	tumor
	germline
	
InstrumentType:
	/instrument/iontorrent/pgm
	/instrument/illumina/hiseq
	/instrument/illumina/miseq
	
PipelineUri:
	/pipeline/orgid/yourpipelineid
