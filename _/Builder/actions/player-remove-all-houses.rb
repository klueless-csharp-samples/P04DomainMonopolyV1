DddResourceBuilder.new
  .init
  .resource_key('action:player:remove-all-houses')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
