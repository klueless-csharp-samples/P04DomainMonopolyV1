DddResourceBuilder.new
  .init
  .resource_key('action:player:card-agreeable-price')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
