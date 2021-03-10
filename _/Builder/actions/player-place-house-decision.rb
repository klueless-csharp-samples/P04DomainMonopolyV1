DddResourceBuilder.new
  .init
  .resource_key('action:player:place-house-decision')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
