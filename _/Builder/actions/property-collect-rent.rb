DddResourceBuilder.new
  .init
  .resource_key('action:property:collect-rent')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
