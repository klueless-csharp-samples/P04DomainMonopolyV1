DddResourceBuilder.new
  .init
  .resource_key('action:bank:collect-fine')
  .language(:csharp)
  .template(:model)
  .generate(:write) # options: :write, :overwrite, :diff 
  .template(:model_designer, with_option: [:a, :b])
  .model
    .guid
    .column(:first_name)
    .column(:last_name)
    .column(:age, :int)
  .generate(:write) # options: :write, :overwrite, :diff 
  .generate_builder(:xyz)
