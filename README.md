# jvf
JSON Variant Format

JSON represenation of genomic variants for use in web services and document-oriented data structures.

# Document URIs
Used to identify specific organizations/laboratories using a reverse FQDN.

OrganizationUri example: /organization/org.ynhh.labmed
	
SubjectURI: /subject/orgid/identifier
  
SpecimenURI: /specimen/orgid/caseid
	
PanelURI: /panel/orgid/panelid/YEARDEVELOPED
	
SpecimenCat: tumor, germline
	
InstrumentType: <br />
	&nbsp;&nbsp;&nbsp;&nbsp;/instrument/iontorrent/pgm<br />
	&nbsp;&nbsp;&nbsp;&nbsp;/instrument/illumina/hiseq<br />
	&nbsp;&nbsp;&nbsp;&nbsp;/instrument/illumina/miseq
	
PipelineUri: /pipeline/orgid/yourpipelineid
