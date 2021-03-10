DddResourceBuilder.new
  .init
  .resource_key('action:player:collect-rent')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
