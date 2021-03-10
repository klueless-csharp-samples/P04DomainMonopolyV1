DddResourceBuilder.new
  .init
  .resource_key('action:player:advance-to-go')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
