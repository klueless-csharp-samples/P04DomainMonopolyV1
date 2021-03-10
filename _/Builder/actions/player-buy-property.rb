DddResourceBuilder.new
  .init
  .resource_key('action:player:buy-property')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
