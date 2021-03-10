DddResourceBuilder.new
  .init
  .resource_key('action:bank:transfer-title-deed')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
