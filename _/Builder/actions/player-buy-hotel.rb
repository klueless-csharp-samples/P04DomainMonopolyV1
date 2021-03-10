DddResourceBuilder.new
  .init
  .resource_key('action:player:buy-hotel')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
