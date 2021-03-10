DddResourceBuilder.new
  .init
  .resource_key('action:bank:pay-salary')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
