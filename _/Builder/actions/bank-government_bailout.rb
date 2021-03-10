DddResourceBuilder.new
  .init
  .resource_key('action:bank:government_bailout')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
