sqlcmd -S 127.0.0.1
-d MBAF
-Q "select 
select tchr.Fname,tchr.Mname,tchr.Lname,Aud.Cabinet,corp.CorpNumber from AudienceType Aud
join Corps corp on corp.Id=aud.CorpID
join Teacher tchr on tchr.Id=aud.TeacherId"
