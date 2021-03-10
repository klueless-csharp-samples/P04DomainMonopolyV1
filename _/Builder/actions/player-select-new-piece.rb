DddResourceBuilder.new
  .init
  .resource_key('action:player:select-new-piece')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
