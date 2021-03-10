DddResourceBuilder.new
  .init
  .resource_key('action:bank:mortgage-property')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
