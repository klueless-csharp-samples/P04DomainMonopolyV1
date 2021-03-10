DddResourceBuilder.new
  .init
  .resource_key('action:player:move-piece')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
