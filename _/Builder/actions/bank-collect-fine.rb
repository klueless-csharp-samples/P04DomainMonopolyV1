DddResourceBuilder.new
  .init
  .resource_key('action:bank:collect-fine')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
